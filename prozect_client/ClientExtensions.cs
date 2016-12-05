using System;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Common;

namespace prozect_client
{
    public static class ClientExtensions
    {
        public static int cnt;
        public static BinaryWriter writer;
        public static TcpClient Client;
        public static BinaryReader reader;
        public static NetworkStream stream;


        public static void setVisiblePanels(this client cs)
        {
            cs.SearchClientPanel.Visible = false;
            cs.ConnectServer_SendData.Visible = false;
            cs.AddMedicine.Visible = false;
            cs.change_p_btn.Visible = false;
        }

        public static void connectToServer(string ip, int port)//פתיחת קשר לשרת
        {
            try
            {
                if (Client == null || (Client != null && !Client.Connected))
                {
                    Client = new TcpClient();

                    Client.Connect(ip, port);

                    stream = Client.GetStream();

                    reader = new BinaryReader(stream);
                    writer = new BinaryWriter(stream);

                    string str = reader.ReadString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to connect");
            }
        }

        public static string retrieveAllMedicne(this client cs)
        {
            connectToServer("127.0.0.1", 8001);
            writer.Write("MedCombo");
            return reader.ReadString();
        }


        public static void notifyCloseRemoteSide(this client cs)
        {
            if (Client != null && Client.Connected)
            {
                writer.Write("EXIT");
            }
        }

        public static void addMedicine(this client cs)//איפוס לאחר הוספת תרופה
        {
            cs.comboMed.SelectedIndex = -1;
            cs.MorningText.Text = null;
            cs.NoonText.Text = null;
            cs.NightText.Text = null;
            cs.NumOfDays.Text = "";


        }

        public static void sendData(this client cs)//בדיקת תקינות ושליחת מידע
        {
            int cnt = 0;
            connectToServer("127.0.0.1", 8001);

            MedSchd med = new MedSchd();

            med.ClientId = cs.text_id.Text;
            med.PharmacistId = Int32.Parse(cs.Pharmacist_number_txt.Text);
            med.MedId = cs.comboMed.SelectedItem.ToString();
            if (cs.MorningText.Text == "")
            {
                med.AmountMorning = 0;
            }
            else
            {
                med.AmountMorning = Int32.Parse(cs.MorningText.Text);
            }
            if (cs.NoonText.Text == "")
            {
                med.AmountNoon = 0;
            }
            else
            {
                med.AmountNoon = Int32.Parse(cs.NoonText.Text);
            }
            if (cs.NightText.Text == "")
            {
                med.AmountNight = 0;
            }
            else
            {
                med.AmountNight = Int32.Parse(cs.NightText.Text);
            }
            med.StartTime = DateTime.Now;
            med.DaysLong = Int32.Parse(cs.NumOfDays_txt.Text);

            string medSchd_json = JsonConvert.SerializeObject(med);

            MedSchd med2 = JsonConvert.DeserializeObject<MedSchd>(medSchd_json);
            while (cnt < 2)
            {
                if (cnt == 0)
                {
                    writer.Write("prescription");
                    cnt++;
                }
                else
                {
                    writer.Write(medSchd_json);
                    cnt++;
                }
            }

            //איפוס משתנים לאחר שליחה
            cs.text_id.Text = "";
            cs.text_fName.Text = "";
            cs.text_lName.Text = "";
            cs.paneldays.Visible = true;
            cs.MorningText.Text = "";
            cs.NoonText.Text = "";
            cs.NightText.Text = "";
            cs.comboMed.SelectedIndex = -1;
            cs.NumOfDays_txt.Text="";
            cs.PhoneNumberText.Text = "";

        }





        public static void BringClient(this client cs)//חיפוש לקוח קיים והבאת הפרטים שלו לשדות המתאימים
        {
            int cnt = 0;
            connectToServer("127.0.0.1", 8001);
            while (cnt < 2)
            {
                if (cnt == 0)
                {
                    writer.Write("clientId");
                    cnt++;
                }
                else
                {
                    writer.Write(cs.Id_old_client_text.Text);
                    string old_client = reader.ReadString();
                    NewClient newClient = JsonConvert.DeserializeObject<NewClient>(old_client);
                    if (newClient.ClientId == null)
                    {
                        MessageBox.Show("מספר תעודת זהות זו אינה נמצאת במערכת... וודא שהמספר נכון ונסה שנית");
                        cnt++;
                    }
                    else
                    {
                        cs.text_id.Text = newClient.ClientId;
                        cs.PhoneNumberText.Text = newClient.PhoneNumber;
                        cs.text_fName.Text = newClient.FirstName;
                        cs.text_lName.Text = newClient.LastName;
                        cnt++;
                    }
                }
            }
            cs.Id_old_client_text.Text = "";
            cs.SearchClientPanel.Visible = false;

        }

        public static void BringPharmacist(this client cs)//יבוא שם פרטי של רוקח לפי מספר מזהה שלו
        {
            string PharmacistName = "";
            int cnt = 0;
            connectToServer("127.0.0.1", 8001);
            while (cnt < 2)
            {
                if (cnt == 0)
                {
                    writer.Write("PharmacistId");
                    cnt++;
                }
                else
                {
                    writer.Write(cs.Pharmacist_number_txt.Text);
                    PharmacistName = reader.ReadString();
                    if (PharmacistName == null)
                    {
                        MessageBox.Show("הרוקח לא נמצא במערכת \n אנא וודא כי המס' נכון ונסה שנית");
                        cnt++;
                    }
                    else
                    {
                        cs.Pharmacist_txt.Text = PharmacistName;
                        cnt++;
                    }
                }
            }
        }



        //public static void BringMed(this client cs)
        //{
        //    connectToServer("127.0.0.1", 8001);
        //    while (cnt < 2)
        //    {
        //        if (cnt == 0)
        //        {
        //            writer.Write("Med");
        //            cnt++;
        //        }
        //        else
        //        {
        //            string json = reader.ReadString();
        //            ClsMed me= JsonConvert.DeserializeObject<ClsMed>(json);
        //            cs.comboMed.DataSource = me;

        //        }
        //    }
        //}


    }

    }
