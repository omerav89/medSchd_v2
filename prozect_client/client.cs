using System;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using prozect_client;
using Newtonsoft.Json;
using System.Data.SqlClient;
using System.Threading;
using System.Collections.Generic;

namespace prozect_client
{

    public partial class client : Form
    {
        
        private bool ok = true;
        private void client_Load(object sender, EventArgs e)//call setVisiblePanels and fill comboMed
        {
            this.setVisiblePanels();
            timer_ComboMed.Start();
            ComboMedThread();
            date_l.Text = DateTime.Now.ToShortDateString();
        }

        public client()
        {
            InitializeComponent();
        }
        private void ConnectServer_SendData_Click(object sender, EventArgs e)//send data to server >> db
        {
            if (comboMed.SelectedIndex != -1)
                ok = true;
            else
                ok = false;
            if (NightText.Text == "" && NoonText.Text == "" && MorningText.Text == "")
            {
                ok = false;
                MessageBox.Show("חייב להכניס כמות כדורים לפחות באחת מהאפשרויות");

            }
            else
            {
                ok = true;
                if (ok)
                {
                    try
                    {
                        this.sendData();
                        SearchClientPanel.Visible = false;

                        text_id.Text = "";
                        text_fName.Text = "";
                        text_lName.Text = "";
                        paneldays.Visible = true;
                        MorningText.Text = "";
                        NoonText.Text = "";
                        NightText.Text = "";
                        comboMed.SelectedIndex = -1;
                        NumOfDays_txt.Text = "";
                        PhoneNumberText.Text = "";

                    }
                    catch (Exception) { }
                }

                else
                {
                    MessageBox.Show("עליך לבדוק כי כל השדות מולאו כראוי כדי להמשיך");
                }
            }

        }

        private void AddMedicine_Click_1(object sender, EventArgs e)//add prescription and restart all except pharmacist and client info
        {
            try
            {
                this.sendData();
                SearchClientPanel.Visible = false;
                comboMed.SelectedIndex = -1;
                MorningText.Text = "";
                NoonText.Text = "";
                NightText.Text = "";
                NumOfDays.Text = "";
            }
            catch (Exception) { }
            
        }

  


    
        private void updateMedCombo()
        {
            string[] meds = this.retrieveAllMedicne().Split(',');          
                this.BeginInvoke((Action)delegate ()
                {
                    foreach (var med in meds)
                    {
                        if (med.Trim() != "")
                            this.comboMed.Items.Add(med);
                    }
                });
            
        }

        private void old_client_Click(object sender, EventArgs e)//open search client
        {
            SearchClientPanel.Visible = !SearchClientPanel.Visible;
        }



        private void Search_client_Click(object sender, EventArgs e)//search client and return his info
        {
            try
            {
                this.BringClient();
                ConnectServer_SendData.Visible = true;
                AddMedicine.Visible = true;
            }
            catch (Exception ex)
            {
            }
            
        }

        private void bring_p_btn_Click(object sender, EventArgs e)//bring pharmacist
        {
            if (Pharmacist_number_txt.Text == "")
            {
                MessageBox.Show("יש להכניס זיהוי רוקח");
            }
            else {
                try
                {
                    this.BringPharmacist();
                    bring_p_btn.Visible = false;
                    change_p_btn.Visible = true;
                    Pharmacist_number_txt.ReadOnly = true;
                }
                catch (Exception) { }
                
            }
        }

        
        private void change_p_btn_Click(object sender, EventArgs e)//visiblity when you want to change pharmacist
        {
            Pharmacist_number_txt.Text = "";
            Pharmacist_number_txt.ReadOnly = false;
            bring_p_btn.Visible = true;
            change_p_btn.Visible = false;
        }

        private void Id_old_client_text_TextChanged(object sender, EventArgs e)//check lengh of client id
        {
            if (Id_old_client_text.TextLength < 9)
            {
                errorId.SetError(Id_old_client_label, "9 ספרות בלבד");
                ok = false;
            }
            else
            {
                errorId.SetError(Id_old_client_label, "");
                ok = true;
                
            }
        }
        
        private void Id_old_client_text_KeyDown(object sender, KeyEventArgs e)//check input of client id
        {
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        ok = false;
                        string abc = "ניתן להכניס מספרים בלבד";
                        DialogResult result1 = MessageBox.Show(abc.ToString(), "Validate numbers", MessageBoxButtons.OK);
                        Id_old_client_text.Text = "";
                    }
                }
            }
            else
                ok = true;
        }

        private void Pharmacist_number_txt_KeyDown(object sender, KeyEventArgs e)//check input of pharmacist id
        {
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        ok = false;
                        string abc = "ניתן להכניס מספרים בלבד";
                        DialogResult result1 = MessageBox.Show(abc.ToString(), "Validate numbers", MessageBoxButtons.OK);
                        Pharmacist_number_txt.Text = "";
                    }
                }
            }
            else
                ok = true;
        }

        private void NumOfDays_txt_KeyDown(object sender, KeyEventArgs e)//check the input at numOfDays
        {
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        ok = false;
                        string abc = "ניתן להכניס מספרים בלבד";
                        DialogResult result1 = MessageBox.Show(abc.ToString(), "Validate numbers", MessageBoxButtons.OK);
                        NumOfDays_txt.Text = "";
                    }
                }
            }
            else
                ok = true;
        }

        private void client_FormClosing(object sender, FormClosingEventArgs e)//closing form
        {
            this.notifyCloseRemoteSide();
            Environment.Exit(Environment.ExitCode);
        }

        private void ComboMedThread ()//start a thread that fill the combobox or meds
        {
            try
            {
                Thread comboUpdate = new Thread(new ThreadStart(updateMedCombo));
                comboUpdate.IsBackground = true;
                comboUpdate.Start();
            }
            catch (Exception ex) { MessageBox.Show("יש בעיה בשרת אנא פנה לשירות טכני"); }
        }

        private void timer_ComboMed_Tick(object sender, EventArgs e)//refresh comboMed every 1 hour
        {
            comboMed.Items.Clear();
            ComboMedThread();
            timer_ComboMed.Start();
        }

        private void refresh_combo_med_Click(object sender, EventArgs e)//refresh comboMed with button click
        {
            comboMed.Items.Clear();
            ComboMedThread();
        }
    }
}
