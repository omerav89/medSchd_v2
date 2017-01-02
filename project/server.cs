using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using Newtonsoft.Json;
using Common;
using System.Text.RegularExpressions;

namespace project
{
    public partial class server : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter_Prescription;
        private DataSet dataSet;
        private bool keepListening;
        Thread thread;
        private MedSchd medSchd;
        private string medSchd_json;
        SqlDataReader reader;
        private bool ok_c = false;



        public server()
        {
            InitializeComponent();
            thread = new Thread(listen);
            thread.IsBackground = true;
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\GitHub\medSchd_v2\DB\TROFOT.mdf;Integrated Security=True;Connect Timeout=30");
        }

        private void server_Load(object sender, EventArgs e)// set visibilty when server load
        {
            keepListening = true;
            thread.Start();
            startListen.Visible = false;
            cancelListen.Visible = true;
            Llisten.Visible = true;
            AddMedicine.Visible = false;
            AddPharmacist.Visible = false;
            cancel.Visible = false;
            panel_Medicine.Visible = false;
            panel_Pharmacist.Visible = false;
            OpenPharmacist.Visible = false;
            OpenMedicine.Visible = false;
            panel_delete_medicine.Visible = false;
            panel_delete_pharmacist.Visible = false;
            Delete_Pharmacist_Medicine.Visible = true;
            Delete_Medicine.Visible = false;
            Delete_Pharmacist.Visible = false;
            Cancel_Delete.Visible = false;
            OpenClient.Visible = false;
            panel_Client.Visible = false;
            panel_delete_client.Visible = false;
            delete_client.Visible = false;
            panel_update_c.Visible = false;
            panel_update_p.Visible = false;
            Update_c_btn.Visible = false;
            Update_p_btn.Visible = false;
            cancel.Visible = false;
            Cancel_update_btn.Visible = false;
        }



        public void listen()//create tcp listener >> start listen >> start background thread of clientHandler 
        {

            keepListening = true;
            IPAddress ipAd = IPAddress.Parse("127.0.0.1");

            TcpListener listener = new TcpListener(ipAd, 8001);

            listener.Start();

            while (keepListening)
            {

                TcpClient client = listener.AcceptTcpClient();


                Thread thread = new Thread(clientHandler);
                thread.IsBackground = true;
                thread.Start(client);

            }

            listener.Stop();

        }

        public void clientHandler(object clientConection)//create new client and open stream >> receive data from client
        {
            NewClient newC = new NewClient();
            string str = "";
            TcpClient client = clientConection as TcpClient;
            if (client == null)
            {
                throw new Exception("A non valid connection");
            }
            NetworkStream stream = client.GetStream();
            BinaryReader reader = new BinaryReader(stream);
            BinaryWriter writer = new BinaryWriter(stream);
            writer.Write("Starting Loop");
            while (client.Connected)
            {

                str = reader.ReadString();

                if (str == "EXIT")
                {
                    client.Close();
                }
                else if (str == "prescription")
                {
                    medSchd_json = reader.ReadString();
                    medSchd = JsonConvert.DeserializeObject<MedSchd>(medSchd_json);
                    initConnection();
                    ClientUpdate up = new ClientUpdate();
                    up.Amount = 10;
                    up.MedType = "Advil";
                    for (int i = 0; i < 10; i++)
                        writer.Write("TESTING: " + i);
                }
                else if (str == "clientId")
                {
                    try
                    {
                        string id = reader.ReadString();
                        bool found = false;
                        DataSet ds_old_Client_id = new DataSet();
                        SqlDataAdapter da_old_Client_id = new SqlDataAdapter("SELECT * FROM Client", connection);
                        da_old_Client_id.Fill(ds_old_Client_id, "Client");
                        DataRow[] arr_client = ds_old_Client_id.Tables["Client"].Select("IdNumber =" + id);

                        foreach (DataRow dr in arr_client)
                        {
                            found = true;
                            newC.ClientId += dr["IdNumber"];
                            newC.FirstName += dr["FirstName"];
                            newC.LastName += dr["LastName"];
                            newC.PhoneNumber += dr["PhoneNumber"];
                        }
                        if (!found)
                        {
                            newC.ClientId = "";
                            newC.FirstName = "";
                            newC.LastName = "";
                            newC.PhoneNumber = "";
                            string client_json = JsonConvert.SerializeObject(newC);
                            writer.Write(client_json);
                        }
                        else
                        {
                            string client_json = JsonConvert.SerializeObject(newC);
                            writer.Write(client_json);
                            newC.ClientId = "";
                            newC.FirstName = "";
                            newC.LastName = "";
                            newC.PhoneNumber = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());

                    }
                }

                else if (str == "PharmacistId")
                {
                    try
                    {
                        string str_p = reader.ReadString();
                        string str_PN = "";
                        bool found = false;
                        DataSet ds_pharmacist = new DataSet();
                        SqlDataAdapter da_pharmacist = new SqlDataAdapter("SELECT * FROM pharmacist", connection);
                        da_pharmacist.Fill(ds_pharmacist, "pharmacist");
                        DataRow[] arr_p = ds_pharmacist.Tables["pharmacist"].Select("IdNumber =" + str_p);

                        foreach (DataRow dr in arr_p)
                        {
                            found = true;
                            str_PN += dr["FirstName"];
                        }
                        if (!found)
                        {
                            str_PN = "";
                            writer.Write(str_PN);
                        }
                        else
                        {
                            writer.Write(str_PN);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else if (str == "MedCombo")
                {

                    DataSet ds_medCombo = new DataSet();
                    SqlDataAdapter da_medCombo = new SqlDataAdapter("SELECT BrandName FROM medicine", connection);
                    da_medCombo.Fill(ds_medCombo, "medicine");
                    DataRow[] arr_p = ds_medCombo.Tables["medicine"].Select();

                    var medList = ds_medCombo.Tables["medicine"]
                        .AsEnumerable()
                        .Select(medicine => new
                        {
                            BrnadName = medicine.Field<string>("BrandName")
                        });

                    string med_str = "";

                    foreach (var med in medList)
                    {
                        med_str += med.BrnadName.Trim() + ",";
                    }

                    writer.Write(med_str);
                }

                else if (str == "androidClient")
                {
                    str = reader.ReadString();
                    DataSet ds_Android = new DataSet();
                    SqlDataAdapter da_android = new SqlDataAdapter("select IdClient,IdMed,AmountMorning, AmountNoon,AmountNight,StartTaking,NumOfDays FROM Prescription", connection);
                    da_android.Fill(ds_Android, "Prescription");
                    DataRow[] arr_p = ds_Android.Tables["Prescription"].Select("IdClient =" + str);

                }
            }
    }


    private void cancelListen_Click(object sender, EventArgs e)//close server
        {
            keepListening = false;
            Environment.Exit(Environment.ExitCode);

        }


        private void setUpDataAdapter()//open connection to db and pull out prescription table
        {

            dataAdapter_Prescription = new SqlDataAdapter("select IdMed, IdClient, StartTaking, NumOfDays, AmountMorning, AmountNoon, AmountNight, IdPharmacist From Prescription", connection);
            SqlCommandBuilder builder_Prescription = new SqlCommandBuilder(dataAdapter_Prescription);


            dataAdapter_Prescription.Fill(dataSet, "Prescription");

            InsertToDataBase();


        }

        private void initConnection()
        {
            try
            {
                dataSet = new DataSet();

                setUpDataAdapter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                throw ex;//give user an option to
            }
        }

        public void updateDataSet(DataSet ds, string tableName)//update prescription table
        {

            try
            {
                connection.Open();
                dataAdapter_Prescription.Update(ds, tableName);
                connection.Close();
                MessageBox.Show("המרשם צורף");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }

        public void InsertToDataBase()//insert data to prescription in db
        {

            try
            {
                DataRow dr_Prescription = dataSet.Tables["Prescription"].NewRow();
                dr_Prescription["IdMed"] = medSchd.MedId;
                dr_Prescription["IdClient"] = medSchd.ClientId;
                dr_Prescription["StartTaking"] = medSchd.StartTime.ToShortDateString();
                dr_Prescription["NumOfDays"] = medSchd.DaysLong;
                dr_Prescription["AmountMorning"] = medSchd.AmountMorning;
                dr_Prescription["AmountNoon"] = medSchd.AmountNoon;
                dr_Prescription["AmountNight"] = medSchd.AmountNight;
                dr_Prescription["IdPharmacist"] = medSchd.PharmacistId;
                dataSet.Tables["Prescription"].Rows.Add(dr_Prescription);
                dataAdapter_Prescription.Update(dataSet, "Prescription");
                MessageBox.Show("המרשם צורף");

                

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);

            }

        }





        public void AddPharmacist_Click_1(object sender, EventArgs e)//add pharmacist to db
        {
            bool good = true;
            if(!Regex.Match(Pharmacist_FName.Text, @"^[א-ת]+|([א-ת]+\s[א-ת]+)$").Success)
            {
                good = false;
            }
            if(!good || !Regex.Match(Pharmacist_LName.Text, @"^[א-ת]+|([א-ת]+\s[א-ת]+)$").Success)
            {
                good = false;
            }
            if (!good || Pharmacist_IdNumber.TextLength < 6)
            {
                MessageBox.Show("עלייך לבדוק את המידע שהכנסת ולנסות שנית\n וודא כי בשמות הוכנסו אותיות ובעברית בלבד");
            }
            else
            {
                try
                {
                    bool found = false;
                    DataSet ds_pharmacist = new DataSet();
                    SqlDataAdapter da_pharmacist = new SqlDataAdapter("SELECT * FROM Pharmacist ", connection);
                    SqlCommandBuilder cmd_B = new SqlCommandBuilder(da_pharmacist);
                    da_pharmacist.Fill(ds_pharmacist, "Pharmacist");
                    DataRow[] arr_P = ds_pharmacist.Tables["Pharmacist"].Select("IdNumber =" + Pharmacist_IdNumber.Text);
                    foreach (DataRow dr in arr_P)
                    {
                        found = true;
                    }
                    if (!found)
                    {
                        DataRow dr_pharmacist = ds_pharmacist.Tables["Pharmacist"].NewRow();
                        dr_pharmacist["IdNumber"] = Pharmacist_IdNumber.Text;
                        dr_pharmacist["FirstName"] = Pharmacist_FName.Text;
                        dr_pharmacist["LastName"] = Pharmacist_LName.Text;
                        ds_pharmacist.Tables["Pharmacist"].Rows.Add(dr_pharmacist);
                        da_pharmacist.Update(ds_pharmacist, "Pharmacist");
                        MessageBox.Show("הרוקח " + Pharmacist_FName.Text + " " + Pharmacist_LName.Text + " נוסף בהצלחה");
                        Pharmacist_FName.Text = "";
                        Pharmacist_LName.Text = "";
                        Pharmacist_IdNumber.Text = "";
                        panel_Pharmacist.Visible = false;
                        Add_Medicine_or_Pharmacist.Visible = true;
                        cancel.Visible = false;
                        OpenPharmacist.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("מספר הזהות כבר קיים אנא הכנס מספר אחר");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("הייתה בעיה בהוספת " + Pharmacist_FName.Text + " " + Pharmacist_LName.Text + " אנא נסה שנית");

                }
            }

        }
        public void AddMedicine_Click(object sender, EventArgs e)//add medicine to db
        {
            bool good = true;
            if (!Regex.Match(GenericName_Text.Text, @"^[a-zA-Z]*$").Success)
            {
                good = false;
            }
            if (!good || !Regex.Match(BrandName_Text.Text, @"^[א-ת]+|([א-ת]+\s[א-ת]+)$").Success)
            {
                good = false;
            }
            if (!good || !Regex.Match(MedType_Text.Text, @"^[א-ת]+|([א-ת]+\s[א-ת]+)$").Success)
            {
                good = false;
            }
            if(comboTakeOption.SelectedIndex==-1)
            {
                good = false;
            }
            if (!good )
            {
                MessageBox.Show("עלייך לבדוק את המידע שהכנסת ולנסות שנית\n שים לב כי על השם הגנרי להיות באנגלית");
            }
            else
            {
                try
                {
                    DataSet ds_medicine = new DataSet();
                    SqlDataAdapter da_medicine = new SqlDataAdapter("SELECT * FROM Medicine", connection);
                    SqlCommandBuilder cmd_medicine = new SqlCommandBuilder(da_medicine);
                    da_medicine.Fill(ds_medicine, "Medicine");
                    DataRow dr_medicine = ds_medicine.Tables["Medicine"].NewRow();
                    dr_medicine["GenericName"] = GenericName_Text.Text;
                    dr_medicine["BrandName"] = BrandName_Text.Text;
                    dr_medicine["MedType"] = MedType_Text.Text;
                    dr_medicine["TakeOption"] = comboTakeOption.SelectedItem;
                    ds_medicine.Tables["Medicine"].Rows.Add(dr_medicine);
                    da_medicine.Update(ds_medicine, "Medicine");
                    MessageBox.Show("התרופה " + BrandName_Text.Text + " נוספה בהצלחה");
                    GenericName_Text.Text = "";
                    BrandName_Text.Text = "";
                    MedType_Text.Text = "";
                    comboTakeOption.SelectedIndex = -1;
                    panel_Medicine.Visible = false;
                    Add_Medicine_or_Pharmacist.Visible = true;
                    cancel.Visible = false;
                    OpenMedicine.Visible = false;
                }
                catch (SqlException ex)
                {

                    MessageBox.Show("הייתה בעיה בהוספת " + BrandName_Text.Text + " אנא נסה שנית");

                }
            }
        }
        private void Add_c_btn_Click(object sender, EventArgs e)//add client to db
        {
            bool good = true;
            if (!Regex.Match(C_FN_txt.Text, @"^[א-ת]+|([א-ת]+\s[א-ת]+)$").Success)
            {
                good = false;
            }
            if (!good || !Regex.Match(C_LN_txt.Text, @"^[א-ת]+|([א-ת]+\s[א-ת]+)$").Success)
            {
                good = false;
            }
            if (!good||C_Id_txt.TextLength < 9 || C_PN_txt.TextLength < 10)
            {
                MessageBox.Show("בדוק היטב את המידע שהכנסת ונסה שנית");
            }
            else
            {
                bool found = false;
                string str_id = "";

                DataSet ds_client = new DataSet();
                SqlDataAdapter da_client = new SqlDataAdapter("SELECT * FROM Client", connection);
                SqlCommandBuilder cmd_client = new SqlCommandBuilder(da_client);
                da_client.Fill(ds_client, "Client");
                DataRow[] arr_c = ds_client.Tables["Client"].Select("IdNumber =" + C_Id_txt.Text);

                foreach (DataRow dr in arr_c)
                {
                    found = true;
                    str_id += dr["IdNumber"].ToString();

                }
                if (!found)
                {
                    try
                    {
                        DataRow dr_medicine = ds_client.Tables["Client"].NewRow();
                        dr_medicine["IdNumber"] = C_Id_txt.Text;
                        dr_medicine["FirstName"] = C_FN_txt.Text;
                        dr_medicine["LastName"] = C_LN_txt.Text;
                        dr_medicine["PhoneNumber"] = C_PN_txt.Text;
                        ds_client.Tables["Client"].Rows.Add(dr_medicine);
                        da_client.Update(ds_client, "Client");
                        MessageBox.Show("הלקוח " + C_FN_txt.Text + "\n " + C_LN_txt.Text + " נוספה בהצלחה");
                        C_Id_txt.Text = "";
                        C_FN_txt.Text = "";
                        C_LN_txt.Text = "";
                        C_PN_txt.Text = "";
                        panel_Client.Visible = false;
                        Add_Medicine_or_Pharmacist.Visible = true;
                        cancel.Visible = false;
                        OpenClient.Visible = false;

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("הייתה בעיה בהוספת " + C_FN_txt.Text + "\n " + C_LN_txt.Text + " אנא נסה שנית");

                    }
                }

                else
                {
                    MessageBox.Show(C_Id_txt.Text + "\n" + " כבר נמצא במערכת");
                    C_Id_txt.Text = "";
                }
            }


        }

        private void Add_Medicine_or_Pharmacist_Click(object sender, EventArgs e)//visibility when want to add med/pharmacist/client
        {
            OpenMedicine.Visible = true;
            OpenPharmacist.Visible = true;
            OpenClient.Visible = true;
            cancel.Visible = true;
        }

        private void OpenMedicine_Click(object sender, EventArgs e)//visibility when want to add medecine
        {
            panel_Medicine.Visible = !panel_Medicine.Visible;
            OpenPharmacist.Visible = false;
            AddMedicine.Visible = true;
            OpenClient.Visible = false;
            panel_Client.Visible = false;
            panel_Pharmacist.Visible = false;
        }

        private void OpenPharmacist_Click(object sender, EventArgs e)//visibility when want to add pharmacist
        {
            panel_Pharmacist.Visible = !panel_Pharmacist.Visible;
            OpenMedicine.Visible = false;
            AddPharmacist.Visible = true;
            OpenClient.Visible = false;
            panel_Medicine.Visible = false;
            panel_Client.Visible = false;
        }
        private void OpenClient_Click(object sender, EventArgs e)//visibility when want to add client
        {
            panel_Client.Visible = !panel_Client.Visible;
            OpenMedicine.Visible = false;
            OpenPharmacist.Visible = false;
            panel_Pharmacist.Visible = false;
            panel_Medicine.Visible = false;
        }


        private void cancel_Click(object sender, EventArgs e)//cancel button  set visibility and set texts
        {
            OpenPharmacist.Visible = false;
            OpenMedicine.Visible = false;
            OpenClient.Visible = false;
            panel_Medicine.Visible = false;
            panel_Pharmacist.Visible = false;
            panel_Client.Visible = false;
            Add_Medicine_or_Pharmacist.Visible = true;
            cancel.Visible = false;
            Pharmacist_FName.Text = "";
            Pharmacist_LName.Text = "";
            Pharmacist_IdNumber.Text = "";
            GenericName_Text.Text = "";
            BrandName_Text.Text = "";
            MedType_Text.Text = "";
            comboTakeOption.SelectedIndex = -1;
            C_Id_txt.Text = "";
            C_FN_txt.Text = "";
            C_LN_txt.Text = "";
            C_PN_txt.Text = "";
            errorProvider_id.SetError(C_ID_L, "");
            errorProvider_id.SetError(C_PN_L, "");
            errorProvider_P_Id.SetError(L_P_id, "");
        }



        private void Delete_Pharmacist_Medicine_Click(object sender, EventArgs e)//visibility after press on delete med/pharmacist/client
        {
            Delete_Medicine.Visible = true;
            Delete_Pharmacist.Visible = true;
            Cancel_Delete.Visible = true;
            delete_client.Visible = true;
        }

        private void Delete_Pharmacist_Click(object sender, EventArgs e)//visibility after press on delete pharmacist
        {
            Delete_Medicine.Visible = false;
            panel_delete_pharmacist.Visible = !panel_delete_pharmacist.Visible;
            delete_client.Visible = false;
            panel_delete_client.Visible = false;
            panel_delete_medicine.Visible = false;
        }

        private void Cancel_Delete_Click(object sender, EventArgs e)//visibility after press on cancel button
        {
            panel_delete_pharmacist.Visible = false;
            panel_delete_medicine.Visible = false;
            Cancel_Delete.Visible = false;
            Delete_Medicine.Visible = false;
            Delete_Pharmacist.Visible = false;
            Delete_Pharmacist_Medicine.Visible = true;
            delete_client.Visible = true;
            panel_delete_client.Visible = false;
            delete_client.Visible = false;
            Medicine_brand_text.Text = "";
            Id_pharmacist_text.Text = "";
            client_delete_text.Text = "";

        }

        private void Delete_Medicine_Click(object sender, EventArgs e)//visibility after press on delete med
        {
            panel_delete_medicine.Visible = !panel_delete_medicine.Visible;
            panel_delete_pharmacist.Visible = false;
            Cancel_Delete.Visible = true;
            Delete_Pharmacist.Visible = false;
            delete_client.Visible = false;
            panel_delete_client.Visible = false;
        }
        private void delete_client_Click(object sender, EventArgs e)//visibility after press on delete client
        {
            panel_delete_client.Visible = !panel_delete_client.Visible;
            panel_delete_pharmacist.Visible = false;
            Cancel_Delete.Visible = true;
            Delete_Pharmacist.Visible = false;
            Delete_Medicine.Visible = false;
            Delete_Medicine.Visible = false;
            panel_delete_medicine.Visible = false;

        }

        private void Delete_p_Click(object sender, EventArgs e)//delete pharmacist by id
        {

            string str_pharmcist_FN = "שם פרטי: ", str_pharmacist_LN = "שם משפחה: ";
            bool found = false;
            DataSet ds_pharmacist_delete = new DataSet();
            SqlDataAdapter da_pharmacist_delete = new SqlDataAdapter("SELECT * FROM Pharmacist", connection);
            da_pharmacist_delete.Fill(ds_pharmacist_delete, "Pharmacist");
            DataRow[] arr_P = ds_pharmacist_delete.Tables["Pharmacist"].Select("IdNumber =" + Id_pharmacist_text.Text);

            foreach (DataRow dr in arr_P)
            {
                found = true;
                str_pharmcist_FN += dr["FirstName"].ToString();
                str_pharmacist_LN += dr["LastName"].ToString();
            }
            if (!found)
            {
                MessageBox.Show("מספר הרוקח אינו קיים במערכת");
                Id_pharmacist_text.Text = "";
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("האם ברצונך למחוק את הרוקח:\n " + str_pharmcist_FN + "\n" + str_pharmacist_LN, "מחיקת רוקח", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    connection.Open();
                    da_pharmacist_delete.DeleteCommand = connection.CreateCommand();
                    da_pharmacist_delete.DeleteCommand.CommandText = "delete Pharmacist where IdNumber=" + Id_pharmacist_text.Text;
                    da_pharmacist_delete.DeleteCommand.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("הרוקח נמחק");
                    Id_pharmacist_text.Text = "";
                    panel_delete_pharmacist.Visible = false;
                    Cancel_Delete.Visible = false;
                    Delete_Pharmacist_Medicine.Visible = true;

                }
            }
        }


        private void delete_m_Click(object sender, EventArgs e)//delete med by brandName
        {
            try
            {
                string str_med = Medicine_brand_text.Text;
                DataSet ds_medicine_delete = new DataSet();
                SqlDataAdapter da_medicine_delete = new SqlDataAdapter("SELECT BrandName FROM Medicine", connection);
                da_medicine_delete.Fill(ds_medicine_delete, "Medicine");
                DataRow[] arr_M = ds_medicine_delete.Tables["Medicine"].Select().Where(brand => ((string)brand[0]).Trim().Equals(Medicine_brand_text.Text)).ToArray();

                if (arr_M.Count() == 0)
                {
                    MessageBox.Show("התרופה אינה קיימת במערכת\n אנא וודא כי השם נכון");
                    Medicine_brand_text.Text = "";
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("האם ברצונך למחוק את התרופה:\n " + Medicine_brand_text.Text, "מחיקת תרופה", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string str_sql = "delete from Medicine where BrandName = @name";
                        connection.Open();
                        da_medicine_delete.DeleteCommand = connection.CreateCommand();
                        da_medicine_delete.DeleteCommand.CommandText = str_sql;
                        da_medicine_delete.DeleteCommand.Parameters.AddWithValue("@name", str_med);
                        da_medicine_delete.DeleteCommand.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("התרופה נמחקה");
                        Medicine_brand_text.Text = "";
                        panel_delete_medicine.Visible = false;
                        Cancel_Delete.Visible = false;
                        Delete_Pharmacist_Medicine.Visible = true;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }

        }

        private void delete_c_Click(object sender, EventArgs e)//deldete client by id
        {
            try
            {
                string str_id = "", str_client_FN = "שם פרטי: ", str_client_LN = "שם משפחה: "; ;
                bool found = false;
                DataSet ds_client_delete = new DataSet();
                SqlDataAdapter da_client_delete = new SqlDataAdapter("SELECT * FROM Client", connection);
                da_client_delete.Fill(ds_client_delete, "Client");
                DataRow[] arr_c = ds_client_delete.Tables["Client"].Select("IdNumber =" + client_delete_text.Text);
                foreach (DataRow dr in arr_c)
                {
                    found = true;
                    str_id = dr["IdNumber"].ToString();
                    str_client_FN += dr["FirstName"].ToString();
                    str_client_LN += dr["LastName"].ToString();
                }
                if (!found)
                {
                    MessageBox.Show("הלקוח אינו קיים במערכת\n אנא וודא כי מספר הזהות נכון");
                    Medicine_brand_text.Text = "";
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("האם ברצונך למחוק את הלקוח\n " + str_client_FN + "\n" + str_client_LN, "מחיקת לקוח", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        connection.Open();
                        da_client_delete.DeleteCommand = connection.CreateCommand();
                        da_client_delete.DeleteCommand.CommandText = "delete client where IdNumber =" + str_id;
                        da_client_delete.DeleteCommand.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("הלקוח נמחק");
                        client_delete_text.Text = "";
                        panel_delete_client.Visible = false;
                        Cancel_Delete.Visible = false;
                        Delete_Pharmacist_Medicine.Visible = true;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }

        }

        private void Update_btn_Click(object sender, EventArgs e)//visibility after press update btn
        {
            Update_p_btn.Visible = true;
            Update_c_btn.Visible = true;
            Cancel_update_btn.Visible = true;
        }

        private void Update_p_btn_Click(object sender, EventArgs e)//visibility pharmacist update
        {
            Update_c_btn.Visible = false;
            panel_update_p.Visible = !panel_update_p.Visible;
            panel_update_c.Visible = false;
        }

        private void Update_c_btn_Click(object sender, EventArgs e)//visibility client update
        {
            Update_p_btn.Visible = false;
            panel_update_c.Visible = !panel_update_c.Visible;
            panel_update_p.Visible = false;
        }

        private void Cancel_update_btn_Click(object sender, EventArgs e)//visibility cancel update btn
        {
            panel_update_c.Visible = false;
            panel_update_p.Visible = false;
            Update_p_btn.Visible = false;
            Update_c_btn.Visible = false;
            Cancel_update_btn.Visible = false;
            Update_c_id_txt.Text = "";
            Update_p_id_txt.Text = "";
            c_update_txt.Text = "";
            p_update_txt.Text = "";
            radioBtn_p_FN.Checked = false;
            radioBtn_p_LN.Checked = false;
            radioBtn_c_FN.Checked = false;
            radioBtn_c_LN.Checked = false;
            radioBtn_c_PN.Checked = false;
            errorProvider_P_Id.SetError(Update_p_id_txt, "");
        }

        private void Update_now_p_btn_Click(object sender, EventArgs e)//update pharmacist info
        {
            bool good = true;
            if (!Regex.Match(p_update_txt.Text, @"^[א-ת]+|([א-ת]+\s[א-ת])$").Success)
            {
                good = false;
            }
            if (!good && !radioBtn_p_FN.Checked && !radioBtn_p_LN.Checked )
            {
                good = false;
            }
            if (!good || Update_p_id_txt.TextLength < 6)
            {
                MessageBox.Show("אנא בדוק שהמידע שהכנסת תקין ולנסות שנית");
            }
            else
            {
                string str_id = "", str_name = p_update_txt.Text;
                bool found = false;
                DataSet ds_pharmacist_update = new DataSet();
                SqlDataAdapter da_pharmacist_update = new SqlDataAdapter("SELECT * FROM Pharmacist", connection);
                da_pharmacist_update.Fill(ds_pharmacist_update, "Pharmacist");
                DataRow[] arr_P = ds_pharmacist_update.Tables["Pharmacist"].Select("IdNumber =" + Update_p_id_txt.Text);

                foreach (DataRow dr in arr_P)
                {
                    found = true;
                    str_id += dr["IdNumber"].ToString();

                }
                if (!found)
                {
                    MessageBox.Show("מספר הרוקח אינו קיים במערכת");
                    Update_p_id_txt.Text = "";
                }
                else
                {

                    if (radioBtn_p_FN.Checked)
                    {
                        string str_sql = "Update Pharmacist set FirstName = @fir where IdNumber = @id";
                        connection.Open();
                        da_pharmacist_update.UpdateCommand = connection.CreateCommand();
                        da_pharmacist_update.UpdateCommand.CommandText = str_sql;
                        da_pharmacist_update.UpdateCommand.Parameters.AddWithValue("@fir", str_name);
                        da_pharmacist_update.UpdateCommand.Parameters.AddWithValue("@id", str_id);
                        da_pharmacist_update.UpdateCommand.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("עודכן בהצלחה");
                        Update_p_id_txt.Text = "";
                        p_update_txt.Text = "";
                        panel_update_p.Visible = false;
                        Update_p_btn.Visible = false;
                        Cancel_update_btn.Visible = false;
                        radioBtn_p_FN.Checked = false;

                    }

                    else
                    {
                        string str_sql = "Update Pharmacist set LastName = @las where IdNumber = @id";
                        connection.Open();
                        da_pharmacist_update.UpdateCommand = connection.CreateCommand();
                        da_pharmacist_update.UpdateCommand.CommandText = str_sql;
                        da_pharmacist_update.UpdateCommand.Parameters.AddWithValue("@las", str_name);
                        da_pharmacist_update.UpdateCommand.Parameters.AddWithValue("@id", str_id);
                        da_pharmacist_update.UpdateCommand.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("עודכן בהצלחה");
                        Update_p_id_txt.Text = "";
                        p_update_txt.Text = "";
                        panel_update_p.Visible = false;
                        Update_p_btn.Visible = false;
                        Cancel_update_btn.Visible = false;
                        radioBtn_p_LN.Checked = false;
                    }

                }
            }

        }

        private void Update_now_c_btn_Click(object sender, EventArgs e)//update client info
        {
            bool good = true;
            if (!Regex.Match(c_update_txt.Text, @"^[א-ת]+|([א-ת]+\s[א-ת])$").Success)
            {
                good = false;
            }
            if (good && !radioBtn_c_FN.Checked && !radioBtn_c_LN.Checked && !radioBtn_c_PN.Checked)
            {
                good = false;
            }
            if (!good || Update_c_id_txt.TextLength < 9)
            {
                MessageBox.Show("אנא בדוק שהמידע שהכנסת תקין ולנסות שנית");
            }
            else
            {
                string str_id = "", str_update = c_update_txt.Text;
                bool found = false;
                DataSet ds_client_update = new DataSet();
                SqlDataAdapter da_client_update = new SqlDataAdapter("SELECT * FROM client", connection);
                da_client_update.Fill(ds_client_update, "client");
                DataRow[] arr_c = ds_client_update.Tables["client"].Select("IdNumber =" + Update_c_id_txt.Text);

                foreach (DataRow dr in arr_c)
                {
                    found = true;
                    str_id += dr["IdNumber"].ToString();

                }
                if (!found)
                {
                    MessageBox.Show("הלקוח אינו קיים במערכת");
                    Update_p_id_txt.Text = "";
                }
                else
                {
                    if (radioBtn_c_PN.Checked)
                    {
                        string str_sql = "Update Client set PhoneNumber = @phon where IdNumber = @id";
                        connection.Open();
                        da_client_update.UpdateCommand = connection.CreateCommand();
                        da_client_update.UpdateCommand.CommandText = str_sql;
                        da_client_update.UpdateCommand.Parameters.AddWithValue("@phon", str_update);
                        da_client_update.UpdateCommand.Parameters.AddWithValue("@id", str_id);
                        da_client_update.UpdateCommand.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("עודכן בהצלחה");
                        Update_c_id_txt.Text = "";
                        c_update_txt.Text = "";
                        panel_update_c.Visible = false;
                        Update_c_btn.Visible = false;
                        Cancel_update_btn.Visible = false;
                        radioBtn_c_PN.Checked = false;
                    }
                    else if (radioBtn_c_FN.Checked)
                    {
                        string str_sql = "Update Client set FirstName = @fir where IdNumber = @id";
                        connection.Open();
                        da_client_update.UpdateCommand = connection.CreateCommand();
                        da_client_update.UpdateCommand.CommandText = str_sql;
                        da_client_update.UpdateCommand.Parameters.AddWithValue("@fir", str_update);
                        da_client_update.UpdateCommand.Parameters.AddWithValue("@id", str_id);
                        da_client_update.UpdateCommand.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("עודכן בהצלחה");
                        Update_c_id_txt.Text = "";
                        c_update_txt.Text = "";
                        panel_update_c.Visible = false;
                        Update_c_btn.Visible = false;
                        Cancel_update_btn.Visible = false;
                        radioBtn_c_FN.Checked = false;
                        radioBtn_c_PN.Checked = false;
                    }
                    else if (radioBtn_c_LN.Checked)
                    {
                        string str_sql = "Update Client set LastName = @las where IdNumber = @id";
                        connection.Open();
                        da_client_update.UpdateCommand = connection.CreateCommand();
                        da_client_update.UpdateCommand.CommandText = str_sql;
                        da_client_update.UpdateCommand.Parameters.AddWithValue("@las", str_update);
                        da_client_update.UpdateCommand.Parameters.AddWithValue("@id", str_id);
                        da_client_update.UpdateCommand.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("עודכן בהצלחה");
                        Update_c_id_txt.Text = "";
                        c_update_txt.Text = "";
                        panel_update_c.Visible = false;
                        Update_c_btn.Visible = false;
                        Cancel_update_btn.Visible = false;
                        radioBtn_c_LN.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show("עלייך לבחור אחת מן האפשרויות");
                    }
                }
            }
        }

        private void C_Id_txt_TextChanged(object sender, EventArgs e)//check id length 
        {
            if (C_Id_txt.TextLength < 9)
            {
                errorProvider_id.SetError(C_ID_L, "9 ספרות בלבד");
                ok_c = false;
            }
            else
            {
                errorProvider_id.SetError(C_ID_L, "");
                ok_c = true;
            }
        }

        private void C_Id_txt_KeyDown(object sender, KeyEventArgs e)//check id input
        {
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        ok_c = false;
                        string abc = "ניתן להכניס מספרים בלבד";
                        DialogResult result1 = MessageBox.Show(abc.ToString(), "Validate numbers", MessageBoxButtons.OK);
                        C_Id_txt.Text = "";
                    }
                }
            }
            else
                ok_c = true;
        }

        private void C_PN_txt_TextChanged(object sender, EventArgs e)//check length phone number
        {
            if (C_PN_txt.TextLength < 10)
            {
                errorProvider_id.SetError(C_PN_L, "9 ספרות בלבד");
                ok_c = false;
            }
            else
            {
                errorProvider_id.SetError(C_PN_L, "");
                ok_c = true;
            }
        }

        private void C_PN_txt_KeyDown(object sender, KeyEventArgs e)//check input phone number
        {
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        ok_c = false;
                        string abc = "ניתן להכניס מספרים בלבד";
                        DialogResult result1 = MessageBox.Show(abc.ToString(), "Validate numbers", MessageBoxButtons.OK);
                        C_PN_txt.Text = "";
                    }
                }
            }
            else
                ok_c = true;
        }

        private void server_FormClosing(object sender, FormClosingEventArgs e)//close server
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void Pharmacist_IdNumber_TextChanged(object sender, EventArgs e)//check length pharmacist id
        {
            if (Pharmacist_IdNumber.TextLength < 6)
            {
                errorProvider_P_Id.SetError(L_P_id, "6 ספרות בלבד");
                
            }
            else
            {
                errorProvider_P_Id.SetError(L_P_id, "");
                
            }
        }

        private void Update_p_id_txt_TextChanged(object sender, EventArgs e)//errorProvider on pharmacist id length in update
        {
            if (Pharmacist_IdNumber.TextLength <6)
            {
                errorProvider_P_Id.SetError(Update_p_id_txt, "6 ספרות בלבד");
                
            }
            else
            {
                errorProvider_P_Id.SetError(Update_p_id_txt, "");
                
            }
        }

        private void Pharmacist_IdNumber_KeyDown(object sender, KeyEventArgs e)//check input id in adding pharmacist
        {
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        string abc = "ניתן להכניס מספרים בלבד";
                        DialogResult result1 = MessageBox.Show(abc.ToString(), "Validate numbers", MessageBoxButtons.OK);
                        Pharmacist_IdNumber.Text = "";
                    }
                }
            }
        }

        private void Update_c_id_txt_TextChanged(object sender, EventArgs e)//errorProvider on client id length in update
        {
            if (Pharmacist_IdNumber.TextLength < 9)
            {
                errorProvider_update_c.SetError(Update_c_id_txt, "9 ספרות בלבד");

            }
            else
            {
                errorProvider_update_c.SetError(Update_c_id_txt, "");

            }
        }

        private void Update_p_id_txt_KeyDown(object sender, KeyEventArgs e)//check pharmacist input id in update
        {
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        string abc = "ניתן להכניס מספרים בלבד";
                        DialogResult result1 = MessageBox.Show(abc.ToString(), "Validate numbers", MessageBoxButtons.OK);
                        Update_p_id_txt.Text = "";
                    }
                }
            }
        }

        private void Update_c_id_txt_KeyDown(object sender, KeyEventArgs e)//check client input id in update
        {
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        string abc = "ניתן להכניס מספרים בלבד";
                        DialogResult result1 = MessageBox.Show(abc.ToString(), "Validate numbers", MessageBoxButtons.OK);
                        Update_c_id_txt.Text = "";
                    }
                }
            }
        }

        private void Id_pharmacist_text_KeyDown(object sender, KeyEventArgs e)//check pharmacist input id for delete
        {
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        string abc = "ניתן להכניס מספרים בלבד";
                        DialogResult result1 = MessageBox.Show(abc.ToString(), "Validate numbers", MessageBoxButtons.OK);
                        Id_pharmacist_text.Text = "";
                    }
                }
            }
        }

        private void client_delete_text_KeyDown(object sender, KeyEventArgs e)////check client input id for delete
        {
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        string abc = "ניתן להכניס מספרים בלבד";
                        DialogResult result1 = MessageBox.Show(abc.ToString(), "Validate numbers", MessageBoxButtons.OK);
                        client_delete_text.Text = "";
                    }
                }
            }
        }

        private void Id_pharmacist_text_TextChanged(object sender, EventArgs e)//check pharmacist id length for delete
        {
            if (Id_pharmacist_text.TextLength < 6)
            {
                errorProvider_id_p_delete.SetError(Id_pharmacist_text, "6 ספרות בלבד");

            }
            else
            {
                errorProvider_id_p_delete.SetError(Id_pharmacist_text, "");

            }
        }

        private void client_delete_text_TextChanged(object sender, EventArgs e)//check client id length for delete
        {
            if (client_delete_text.TextLength < 9)
            {
                errorProvider_id_c_delete.SetError(client_delete_text, "9 ספרות בלבד");
                ok_c = false;
            }
            else
            {
                errorProvider_id_c_delete.SetError(client_delete_text, "");
                ok_c = true;
            }
        }
    }
}





