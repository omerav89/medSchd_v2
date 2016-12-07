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
        public client()
        {
            InitializeComponent();            
        }              
        private void ConnectServer_SendData_Click(object sender, EventArgs e)//שליחת מידע לשרת ומשם לבסיס נתונים
        {
            if (comboMed.SelectedIndex != -1)
                ok = true;
            else
                ok = false;
            if (NightText.Text == "" && NoonText.Text == "" && MorningText.Text == "")
            {
                ok = false;
                MessageBox.Show("חייב להכניס כמות כדורים לפחות באחת מין האפשרויות");

            }
            else
            {
                ok = true;
                if (ok)
                {
                    this.sendData();
                    SearchClientPanel.Visible = false;
                }

                else
                {
                    MessageBox.Show("עליך לבדוק כי כל השדות מולאו כראוי כדי להמשיך");
                }
            }
        }

        private void AddMedicine_Click_1(object sender, EventArgs e)//הוספת תרופה... פרטים מזהים נשארים וכל השאר מאופסים
        {
            this.addMedicine();
            SearchClientPanel.Visible = false;
        }

  


        private void client_Load(object sender, EventArgs e)//הסדרת הפנאלים בעליית הפורם ופתיחת תהליכון של מילוי תרופות
        {
            this.setVisiblePanels();
            try
            {
                Thread comboUpdate = new Thread(new ThreadStart(updateMedCombo));
                comboUpdate.Start();
            }
            catch (Exception ex) { MessageBox.Show("יש בעיה בשרת אנא פנה לשירות טכני"); }
        }

        private void updateMedCombo()
        {
            string[] meds = this.retrieveAllMedicne().Split(',');
            this.BeginInvoke((Action)delegate () {
                foreach (var med in meds)
                {
                    if (med.Trim() != "")
                        this.comboMed.Items.Add(med);
                }
            });
        }

        private void old_client_Click(object sender, EventArgs e)//פתיחה של חיפוש לקוח קיים
        {
            SearchClientPanel.Visible = !SearchClientPanel.Visible;
        }



        private void Search_client_Click(object sender, EventArgs e)//קריאה לחיפוש לקוח קיים והבאת הפרטים שלו לשדות המתאימים
        {
            this.BringClient();
            ConnectServer_SendData.Visible = true;
            AddMedicine.Visible = true;
        }

        private void bring_p_btn_Click(object sender, EventArgs e)//קריאה להבאת שם רוקח
        {
            this.BringPharmacist();
            bring_p_btn.Visible = false;
            change_p_btn.Visible = true;
            Pharmacist_number_txt.ReadOnly = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void change_p_btn_Click(object sender, EventArgs e)//נראות החלפת מס' רוקח
        {
            Pharmacist_number_txt.Text = "";
            Pharmacist_number_txt.ReadOnly = false;
            bring_p_btn.Visible = true;
            change_p_btn.Visible = false;
        }

        private void Id_old_client_text_TextChanged(object sender, EventArgs e)//בדיקת אורך קלט והתראה של מספר ת"ז
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
                throw new Exception();
            }
        }
        
        private void Id_old_client_text_KeyDown(object sender, KeyEventArgs e)//תקינות קלט של מספר ת"ז
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

        private void Pharmacist_number_txt_KeyDown(object sender, KeyEventArgs e)//תקינות קלט מס' רוקח
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

        private void NumOfDays_txt_KeyDown(object sender, KeyEventArgs e)//תקינות קלט של מספר ימים
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

        private void client_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.notifyCloseRemoteSide();
            Environment.Exit(Environment.ExitCode);
        }



    }
}
