namespace project
{
    partial class server
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startListen = new System.Windows.Forms.Button();
            this.cancelListen = new System.Windows.Forms.Button();
            this.Llisten = new System.Windows.Forms.Label();
            this.Add_Medicine_or_Pharmacist = new System.Windows.Forms.Button();
            this.OpenMedicine = new System.Windows.Forms.Button();
            this.OpenPharmacist = new System.Windows.Forms.Button();
            this.AddMedicine = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.BrandName_Text = new System.Windows.Forms.TextBox();
            this.MedType_Text = new System.Windows.Forms.TextBox();
            this.GenericName_Text = new System.Windows.Forms.TextBox();
            this.GenericName_label = new System.Windows.Forms.Label();
            this.BrandName_label = new System.Windows.Forms.Label();
            this.MedType_label = new System.Windows.Forms.Label();
            this.TakeOption_label = new System.Windows.Forms.Label();
            this.TakeOption_Text = new System.Windows.Forms.TextBox();
            this.Pharmacist_FName = new System.Windows.Forms.TextBox();
            this.Pharmacist_LName = new System.Windows.Forms.TextBox();
            this.L_P_FN = new System.Windows.Forms.Label();
            this.C_PN_L = new System.Windows.Forms.Label();
            this.AddPharmacist = new System.Windows.Forms.Button();
            this.Delete_Pharmacist_Medicine = new System.Windows.Forms.Button();
            this.Delete_Medicine = new System.Windows.Forms.Button();
            this.Delete_Pharmacist = new System.Windows.Forms.Button();
            this.Id_pharmacist_text = new System.Windows.Forms.TextBox();
            this.Medicine_brand_text = new System.Windows.Forms.TextBox();
            this.Medicine_generic_for_delete = new System.Windows.Forms.Label();
            this.ID_Pharmacist_for_delete = new System.Windows.Forms.Label();
            this.delete_m = new System.Windows.Forms.Button();
            this.Delete_p = new System.Windows.Forms.Button();
            this.Cancel_Delete = new System.Windows.Forms.Button();
            this.panel_Medicine = new System.Windows.Forms.Panel();
            this.panel_Pharmacist = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_delete_medicine = new System.Windows.Forms.Panel();
            this.panel_delete_pharmacist = new System.Windows.Forms.Panel();
            this.OpenClient = new System.Windows.Forms.Button();
            this.C_ID_L = new System.Windows.Forms.Label();
            this.C_FN_L = new System.Windows.Forms.Label();
            this.C_LN_L = new System.Windows.Forms.Label();
            this.C_Id_txt = new System.Windows.Forms.TextBox();
            this.C_PN_txt = new System.Windows.Forms.TextBox();
            this.C_FN_txt = new System.Windows.Forms.TextBox();
            this.C_LN_txt = new System.Windows.Forms.TextBox();
            this.Add_c_btn = new System.Windows.Forms.Button();
            this.panel_Client = new System.Windows.Forms.Panel();
            this.delete_client = new System.Windows.Forms.Button();
            this.panel_delete_client = new System.Windows.Forms.Panel();
            this.enter_id_label = new System.Windows.Forms.Label();
            this.delete_c = new System.Windows.Forms.Button();
            this.client_delete_text = new System.Windows.Forms.TextBox();
            this.Update_c_btn = new System.Windows.Forms.Button();
            this.Update_p_btn = new System.Windows.Forms.Button();
            this.panel_update_c = new System.Windows.Forms.Panel();
            this.Update_c_id_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioBtn_c_LN = new System.Windows.Forms.RadioButton();
            this.radioBtn_c_FN = new System.Windows.Forms.RadioButton();
            this.radioBtn_c_PN = new System.Windows.Forms.RadioButton();
            this.Update_now_c_btn = new System.Windows.Forms.Button();
            this.c_update_txt = new System.Windows.Forms.TextBox();
            this.panel_update_p = new System.Windows.Forms.Panel();
            this.Update_p_id_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioBtn_p_FN = new System.Windows.Forms.RadioButton();
            this.radioBtn_p_LN = new System.Windows.Forms.RadioButton();
            this.Update_now_p_btn = new System.Windows.Forms.Button();
            this.p_update_txt = new System.Windows.Forms.TextBox();
            this.Update_btn = new System.Windows.Forms.Button();
            this.Cancel_update_btn = new System.Windows.Forms.Button();
            this.errorProvider_id = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_phone = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_Medicine.SuspendLayout();
            this.panel_Pharmacist.SuspendLayout();
            this.panel_delete_medicine.SuspendLayout();
            this.panel_delete_pharmacist.SuspendLayout();
            this.panel_Client.SuspendLayout();
            this.panel_delete_client.SuspendLayout();
            this.panel_update_c.SuspendLayout();
            this.panel_update_p.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_phone)).BeginInit();
            this.SuspendLayout();
            // 
            // startListen
            // 
            this.startListen.Location = new System.Drawing.Point(380, 562);
            this.startListen.Name = "startListen";
            this.startListen.Size = new System.Drawing.Size(88, 33);
            this.startListen.TabIndex = 0;
            this.startListen.Text = "האזן";
            this.startListen.UseVisualStyleBackColor = true;
            this.startListen.Click += new System.EventHandler(this.startListen_Click);
            // 
            // cancelListen
            // 
            this.cancelListen.Location = new System.Drawing.Point(286, 561);
            this.cancelListen.Name = "cancelListen";
            this.cancelListen.Size = new System.Drawing.Size(88, 34);
            this.cancelListen.TabIndex = 1;
            this.cancelListen.Text = "בטל האזנה";
            this.cancelListen.UseVisualStyleBackColor = true;
            this.cancelListen.Visible = false;
            this.cancelListen.Click += new System.EventHandler(this.cancelListen_Click);
            // 
            // Llisten
            // 
            this.Llisten.AutoSize = true;
            this.Llisten.Location = new System.Drawing.Point(346, 598);
            this.Llisten.Name = "Llisten";
            this.Llisten.Size = new System.Drawing.Size(46, 13);
            this.Llisten.TabIndex = 2;
            this.Llisten.Text = "...מאזין";
            this.Llisten.UseMnemonic = false;
            this.Llisten.Visible = false;
            // 
            // Add_Medicine_or_Pharmacist
            // 
            this.Add_Medicine_or_Pharmacist.Location = new System.Drawing.Point(656, 9);
            this.Add_Medicine_or_Pharmacist.Name = "Add_Medicine_or_Pharmacist";
            this.Add_Medicine_or_Pharmacist.Size = new System.Drawing.Size(167, 26);
            this.Add_Medicine_or_Pharmacist.TabIndex = 3;
            this.Add_Medicine_or_Pharmacist.Text = "הוסף תרופה / רוקח / לקוח";
            this.Add_Medicine_or_Pharmacist.UseVisualStyleBackColor = true;
            this.Add_Medicine_or_Pharmacist.Click += new System.EventHandler(this.Add_Medicine_or_Pharmacist_Click);
            // 
            // OpenMedicine
            // 
            this.OpenMedicine.Location = new System.Drawing.Point(829, 36);
            this.OpenMedicine.Name = "OpenMedicine";
            this.OpenMedicine.Size = new System.Drawing.Size(48, 26);
            this.OpenMedicine.TabIndex = 4;
            this.OpenMedicine.Text = "תרופה";
            this.OpenMedicine.UseVisualStyleBackColor = true;
            this.OpenMedicine.Click += new System.EventHandler(this.OpenMedicine_Click);
            // 
            // OpenPharmacist
            // 
            this.OpenPharmacist.Location = new System.Drawing.Point(711, 39);
            this.OpenPharmacist.Name = "OpenPharmacist";
            this.OpenPharmacist.Size = new System.Drawing.Size(48, 26);
            this.OpenPharmacist.TabIndex = 5;
            this.OpenPharmacist.Text = "רוקח";
            this.OpenPharmacist.UseVisualStyleBackColor = true;
            this.OpenPharmacist.Click += new System.EventHandler(this.OpenPharmacist_Click);
            // 
            // AddMedicine
            // 
            this.AddMedicine.Location = new System.Drawing.Point(22, 165);
            this.AddMedicine.Name = "AddMedicine";
            this.AddMedicine.Size = new System.Drawing.Size(89, 26);
            this.AddMedicine.TabIndex = 6;
            this.AddMedicine.Text = "הוסף תרופה";
            this.AddMedicine.UseVisualStyleBackColor = true;
            this.AddMedicine.Click += new System.EventHandler(this.AddMedicine_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(703, 275);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(56, 26);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "ביטול";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // BrandName_Text
            // 
            this.BrandName_Text.Location = new System.Drawing.Point(11, 60);
            this.BrandName_Text.Name = "BrandName_Text";
            this.BrandName_Text.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BrandName_Text.Size = new System.Drawing.Size(100, 20);
            this.BrandName_Text.TabIndex = 9;
            // 
            // MedType_Text
            // 
            this.MedType_Text.Location = new System.Drawing.Point(11, 98);
            this.MedType_Text.Name = "MedType_Text";
            this.MedType_Text.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MedType_Text.Size = new System.Drawing.Size(100, 20);
            this.MedType_Text.TabIndex = 10;
            // 
            // GenericName_Text
            // 
            this.GenericName_Text.Location = new System.Drawing.Point(11, 21);
            this.GenericName_Text.Name = "GenericName_Text";
            this.GenericName_Text.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GenericName_Text.Size = new System.Drawing.Size(100, 20);
            this.GenericName_Text.TabIndex = 11;
            // 
            // GenericName_label
            // 
            this.GenericName_label.AutoSize = true;
            this.GenericName_label.Location = new System.Drawing.Point(63, 5);
            this.GenericName_label.Name = "GenericName_label";
            this.GenericName_label.Size = new System.Drawing.Size(48, 13);
            this.GenericName_label.TabIndex = 14;
            this.GenericName_label.Text = "שם גנרי";
            // 
            // BrandName_label
            // 
            this.BrandName_label.AutoSize = true;
            this.BrandName_label.Location = new System.Drawing.Point(60, 44);
            this.BrandName_label.Name = "BrandName_label";
            this.BrandName_label.Size = new System.Drawing.Size(51, 13);
            this.BrandName_label.TabIndex = 15;
            this.BrandName_label.Text = "שם מותג";
            // 
            // MedType_label
            // 
            this.MedType_label.AutoSize = true;
            this.MedType_label.Location = new System.Drawing.Point(51, 83);
            this.MedType_label.Name = "MedType_label";
            this.MedType_label.Size = new System.Drawing.Size(60, 13);
            this.MedType_label.TabIndex = 16;
            this.MedType_label.Text = "סוג תרופה";
            // 
            // TakeOption_label
            // 
            this.TakeOption_label.AutoSize = true;
            this.TakeOption_label.Location = new System.Drawing.Point(43, 123);
            this.TakeOption_label.Name = "TakeOption_label";
            this.TakeOption_label.Size = new System.Drawing.Size(68, 13);
            this.TakeOption_label.TabIndex = 19;
            this.TakeOption_label.Text = "אופן לקיחה";
            // 
            // TakeOption_Text
            // 
            this.TakeOption_Text.Location = new System.Drawing.Point(11, 139);
            this.TakeOption_Text.Name = "TakeOption_Text";
            this.TakeOption_Text.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TakeOption_Text.Size = new System.Drawing.Size(100, 20);
            this.TakeOption_Text.TabIndex = 17;
            // 
            // Pharmacist_FName
            // 
            this.Pharmacist_FName.Location = new System.Drawing.Point(18, 58);
            this.Pharmacist_FName.Name = "Pharmacist_FName";
            this.Pharmacist_FName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Pharmacist_FName.Size = new System.Drawing.Size(100, 20);
            this.Pharmacist_FName.TabIndex = 12;
            // 
            // Pharmacist_LName
            // 
            this.Pharmacist_LName.Location = new System.Drawing.Point(18, 117);
            this.Pharmacist_LName.Name = "Pharmacist_LName";
            this.Pharmacist_LName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Pharmacist_LName.Size = new System.Drawing.Size(100, 20);
            this.Pharmacist_LName.TabIndex = 13;
            // 
            // L_P_FN
            // 
            this.L_P_FN.AutoSize = true;
            this.L_P_FN.Location = new System.Drawing.Point(67, 31);
            this.L_P_FN.Name = "L_P_FN";
            this.L_P_FN.Size = new System.Drawing.Size(51, 13);
            this.L_P_FN.TabIndex = 17;
            this.L_P_FN.Text = "שם פרטי";
            // 
            // C_PN_L
            // 
            this.C_PN_L.AutoSize = true;
            this.C_PN_L.Location = new System.Drawing.Point(37, 42);
            this.C_PN_L.Name = "C_PN_L";
            this.C_PN_L.Size = new System.Drawing.Size(65, 13);
            this.C_PN_L.TabIndex = 18;
            this.C_PN_L.Text = "מס\' פלאפון";
            // 
            // AddPharmacist
            // 
            this.AddPharmacist.Location = new System.Drawing.Point(28, 170);
            this.AddPharmacist.Name = "AddPharmacist";
            this.AddPharmacist.Size = new System.Drawing.Size(75, 27);
            this.AddPharmacist.TabIndex = 19;
            this.AddPharmacist.Text = "הוסף רוקח";
            this.AddPharmacist.UseVisualStyleBackColor = true;
            this.AddPharmacist.Click += new System.EventHandler(this.AddPharmacist_Click_1);
            // 
            // Delete_Pharmacist_Medicine
            // 
            this.Delete_Pharmacist_Medicine.Location = new System.Drawing.Point(141, 9);
            this.Delete_Pharmacist_Medicine.Name = "Delete_Pharmacist_Medicine";
            this.Delete_Pharmacist_Medicine.Size = new System.Drawing.Size(153, 23);
            this.Delete_Pharmacist_Medicine.TabIndex = 21;
            this.Delete_Pharmacist_Medicine.Text = "מחק תרופה / רוקח / לקוח";
            this.Delete_Pharmacist_Medicine.UseVisualStyleBackColor = true;
            this.Delete_Pharmacist_Medicine.Click += new System.EventHandler(this.Delete_Pharmacist_Medicine_Click);
            // 
            // Delete_Medicine
            // 
            this.Delete_Medicine.Location = new System.Drawing.Point(349, 41);
            this.Delete_Medicine.Name = "Delete_Medicine";
            this.Delete_Medicine.Size = new System.Drawing.Size(70, 23);
            this.Delete_Medicine.TabIndex = 22;
            this.Delete_Medicine.Text = "תרופה";
            this.Delete_Medicine.UseVisualStyleBackColor = true;
            this.Delete_Medicine.Click += new System.EventHandler(this.Delete_Medicine_Click);
            // 
            // Delete_Pharmacist
            // 
            this.Delete_Pharmacist.Location = new System.Drawing.Point(189, 43);
            this.Delete_Pharmacist.Name = "Delete_Pharmacist";
            this.Delete_Pharmacist.Size = new System.Drawing.Size(65, 23);
            this.Delete_Pharmacist.TabIndex = 23;
            this.Delete_Pharmacist.Text = "רוקח";
            this.Delete_Pharmacist.UseVisualStyleBackColor = true;
            this.Delete_Pharmacist.Click += new System.EventHandler(this.Delete_Pharmacist_Click);
            // 
            // Id_pharmacist_text
            // 
            this.Id_pharmacist_text.Location = new System.Drawing.Point(52, 34);
            this.Id_pharmacist_text.Name = "Id_pharmacist_text";
            this.Id_pharmacist_text.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Id_pharmacist_text.Size = new System.Drawing.Size(65, 20);
            this.Id_pharmacist_text.TabIndex = 24;
            // 
            // Medicine_brand_text
            // 
            this.Medicine_brand_text.Location = new System.Drawing.Point(22, 34);
            this.Medicine_brand_text.Name = "Medicine_brand_text";
            this.Medicine_brand_text.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Medicine_brand_text.Size = new System.Drawing.Size(70, 20);
            this.Medicine_brand_text.TabIndex = 25;
            // 
            // Medicine_generic_for_delete
            // 
            this.Medicine_generic_for_delete.AutoSize = true;
            this.Medicine_generic_for_delete.Location = new System.Drawing.Point(19, 8);
            this.Medicine_generic_for_delete.Name = "Medicine_generic_for_delete";
            this.Medicine_generic_for_delete.Size = new System.Drawing.Size(80, 13);
            this.Medicine_generic_for_delete.TabIndex = 26;
            this.Medicine_generic_for_delete.Text = "הכנס שם מותג";
            // 
            // ID_Pharmacist_for_delete
            // 
            this.ID_Pharmacist_for_delete.AutoSize = true;
            this.ID_Pharmacist_for_delete.Location = new System.Drawing.Point(11, 6);
            this.ID_Pharmacist_for_delete.Name = "ID_Pharmacist_for_delete";
            this.ID_Pharmacist_for_delete.Size = new System.Drawing.Size(146, 13);
            this.ID_Pharmacist_for_delete.TabIndex = 27;
            this.ID_Pharmacist_for_delete.Text = "הכנס מספר מזהה של הרוקח";
            // 
            // delete_m
            // 
            this.delete_m.Location = new System.Drawing.Point(39, 70);
            this.delete_m.Name = "delete_m";
            this.delete_m.Size = new System.Drawing.Size(53, 28);
            this.delete_m.TabIndex = 28;
            this.delete_m.Text = "מחק";
            this.delete_m.UseVisualStyleBackColor = true;
            this.delete_m.Click += new System.EventHandler(this.delete_m_Click);
            // 
            // Delete_p
            // 
            this.Delete_p.Location = new System.Drawing.Point(64, 66);
            this.Delete_p.Name = "Delete_p";
            this.Delete_p.Size = new System.Drawing.Size(53, 25);
            this.Delete_p.TabIndex = 29;
            this.Delete_p.Text = "מחק";
            this.Delete_p.UseVisualStyleBackColor = true;
            this.Delete_p.Click += new System.EventHandler(this.Delete_p_Click);
            // 
            // Cancel_Delete
            // 
            this.Cancel_Delete.Location = new System.Drawing.Point(201, 189);
            this.Cancel_Delete.Name = "Cancel_Delete";
            this.Cancel_Delete.Size = new System.Drawing.Size(48, 28);
            this.Cancel_Delete.TabIndex = 31;
            this.Cancel_Delete.Text = "ביטול";
            this.Cancel_Delete.UseVisualStyleBackColor = true;
            this.Cancel_Delete.Click += new System.EventHandler(this.Cancel_Delete_Click);
            // 
            // panel_Medicine
            // 
            this.panel_Medicine.Controls.Add(this.TakeOption_label);
            this.panel_Medicine.Controls.Add(this.TakeOption_Text);
            this.panel_Medicine.Controls.Add(this.MedType_label);
            this.panel_Medicine.Controls.Add(this.BrandName_label);
            this.panel_Medicine.Controls.Add(this.GenericName_label);
            this.panel_Medicine.Controls.Add(this.GenericName_Text);
            this.panel_Medicine.Controls.Add(this.MedType_Text);
            this.panel_Medicine.Controls.Add(this.BrandName_Text);
            this.panel_Medicine.Controls.Add(this.AddMedicine);
            this.panel_Medicine.Location = new System.Drawing.Point(791, 68);
            this.panel_Medicine.Name = "panel_Medicine";
            this.panel_Medicine.Size = new System.Drawing.Size(117, 197);
            this.panel_Medicine.TabIndex = 32;
            // 
            // panel_Pharmacist
            // 
            this.panel_Pharmacist.Controls.Add(this.label1);
            this.panel_Pharmacist.Controls.Add(this.AddPharmacist);
            this.panel_Pharmacist.Controls.Add(this.L_P_FN);
            this.panel_Pharmacist.Controls.Add(this.Pharmacist_LName);
            this.panel_Pharmacist.Controls.Add(this.Pharmacist_FName);
            this.panel_Pharmacist.Location = new System.Drawing.Point(656, 65);
            this.panel_Pharmacist.Name = "panel_Pharmacist";
            this.panel_Pharmacist.Size = new System.Drawing.Size(129, 201);
            this.panel_Pharmacist.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "שם משפחה";
            // 
            // panel_delete_medicine
            // 
            this.panel_delete_medicine.Controls.Add(this.Medicine_generic_for_delete);
            this.panel_delete_medicine.Controls.Add(this.delete_m);
            this.panel_delete_medicine.Controls.Add(this.Medicine_brand_text);
            this.panel_delete_medicine.Location = new System.Drawing.Point(327, 72);
            this.panel_delete_medicine.Name = "panel_delete_medicine";
            this.panel_delete_medicine.Size = new System.Drawing.Size(115, 111);
            this.panel_delete_medicine.TabIndex = 34;
            // 
            // panel_delete_pharmacist
            // 
            this.panel_delete_pharmacist.Controls.Add(this.Delete_p);
            this.panel_delete_pharmacist.Controls.Add(this.ID_Pharmacist_for_delete);
            this.panel_delete_pharmacist.Controls.Add(this.Id_pharmacist_text);
            this.panel_delete_pharmacist.Location = new System.Drawing.Point(137, 72);
            this.panel_delete_pharmacist.Name = "panel_delete_pharmacist";
            this.panel_delete_pharmacist.Size = new System.Drawing.Size(165, 111);
            this.panel_delete_pharmacist.TabIndex = 35;
            // 
            // OpenClient
            // 
            this.OpenClient.Location = new System.Drawing.Point(576, 40);
            this.OpenClient.Name = "OpenClient";
            this.OpenClient.Size = new System.Drawing.Size(48, 26);
            this.OpenClient.TabIndex = 36;
            this.OpenClient.Text = "לקוח";
            this.OpenClient.UseVisualStyleBackColor = true;
            this.OpenClient.Click += new System.EventHandler(this.OpenClient_Click);
            // 
            // C_ID_L
            // 
            this.C_ID_L.AutoSize = true;
            this.C_ID_L.Location = new System.Drawing.Point(78, 3);
            this.C_ID_L.Name = "C_ID_L";
            this.C_ID_L.Size = new System.Drawing.Size(24, 13);
            this.C_ID_L.TabIndex = 21;
            this.C_ID_L.Text = "ת\"ז";
            // 
            // C_FN_L
            // 
            this.C_FN_L.AutoSize = true;
            this.C_FN_L.Location = new System.Drawing.Point(51, 80);
            this.C_FN_L.Name = "C_FN_L";
            this.C_FN_L.Size = new System.Drawing.Size(51, 13);
            this.C_FN_L.TabIndex = 37;
            this.C_FN_L.Text = "שם פרטי";
            // 
            // C_LN_L
            // 
            this.C_LN_L.AutoSize = true;
            this.C_LN_L.Location = new System.Drawing.Point(39, 119);
            this.C_LN_L.Name = "C_LN_L";
            this.C_LN_L.Size = new System.Drawing.Size(63, 13);
            this.C_LN_L.TabIndex = 38;
            this.C_LN_L.Text = "שם משפחה";
            // 
            // C_Id_txt
            // 
            this.C_Id_txt.Location = new System.Drawing.Point(0, 19);
            this.C_Id_txt.MaxLength = 9;
            this.C_Id_txt.Name = "C_Id_txt";
            this.C_Id_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.C_Id_txt.Size = new System.Drawing.Size(100, 20);
            this.C_Id_txt.TabIndex = 21;
            this.C_Id_txt.TextChanged += new System.EventHandler(this.C_Id_txt_TextChanged);
            this.C_Id_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.C_Id_txt_KeyDown);
            // 
            // C_PN_txt
            // 
            this.C_PN_txt.Location = new System.Drawing.Point(2, 58);
            this.C_PN_txt.MaxLength = 10;
            this.C_PN_txt.Name = "C_PN_txt";
            this.C_PN_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.C_PN_txt.Size = new System.Drawing.Size(100, 20);
            this.C_PN_txt.TabIndex = 39;
            this.C_PN_txt.TextChanged += new System.EventHandler(this.C_PN_txt_TextChanged);
            this.C_PN_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.C_PN_txt_KeyDown);
            // 
            // C_FN_txt
            // 
            this.C_FN_txt.Location = new System.Drawing.Point(2, 96);
            this.C_FN_txt.MaxLength = 20;
            this.C_FN_txt.Name = "C_FN_txt";
            this.C_FN_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.C_FN_txt.Size = new System.Drawing.Size(100, 20);
            this.C_FN_txt.TabIndex = 40;
            // 
            // C_LN_txt
            // 
            this.C_LN_txt.Location = new System.Drawing.Point(0, 135);
            this.C_LN_txt.MaxLength = 20;
            this.C_LN_txt.Name = "C_LN_txt";
            this.C_LN_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.C_LN_txt.Size = new System.Drawing.Size(100, 20);
            this.C_LN_txt.TabIndex = 41;
            // 
            // Add_c_btn
            // 
            this.Add_c_btn.Location = new System.Drawing.Point(25, 170);
            this.Add_c_btn.Name = "Add_c_btn";
            this.Add_c_btn.Size = new System.Drawing.Size(75, 27);
            this.Add_c_btn.TabIndex = 21;
            this.Add_c_btn.Text = "הוסף לקוח";
            this.Add_c_btn.UseVisualStyleBackColor = true;
            this.Add_c_btn.Click += new System.EventHandler(this.Add_c_btn_Click);
            // 
            // panel_Client
            // 
            this.panel_Client.Controls.Add(this.Add_c_btn);
            this.panel_Client.Controls.Add(this.C_LN_txt);
            this.panel_Client.Controls.Add(this.C_FN_txt);
            this.panel_Client.Controls.Add(this.C_PN_txt);
            this.panel_Client.Controls.Add(this.C_Id_txt);
            this.panel_Client.Controls.Add(this.C_LN_L);
            this.panel_Client.Controls.Add(this.C_FN_L);
            this.panel_Client.Controls.Add(this.C_ID_L);
            this.panel_Client.Controls.Add(this.C_PN_L);
            this.panel_Client.Location = new System.Drawing.Point(524, 65);
            this.panel_Client.Name = "panel_Client";
            this.panel_Client.Size = new System.Drawing.Size(116, 201);
            this.panel_Client.TabIndex = 42;
            // 
            // delete_client
            // 
            this.delete_client.Location = new System.Drawing.Point(33, 43);
            this.delete_client.Name = "delete_client";
            this.delete_client.Size = new System.Drawing.Size(70, 23);
            this.delete_client.TabIndex = 43;
            this.delete_client.Text = "לקוח";
            this.delete_client.UseVisualStyleBackColor = true;
            this.delete_client.Click += new System.EventHandler(this.delete_client_Click);
            // 
            // panel_delete_client
            // 
            this.panel_delete_client.Controls.Add(this.enter_id_label);
            this.panel_delete_client.Controls.Add(this.delete_c);
            this.panel_delete_client.Controls.Add(this.client_delete_text);
            this.panel_delete_client.Location = new System.Drawing.Point(11, 74);
            this.panel_delete_client.Name = "panel_delete_client";
            this.panel_delete_client.Size = new System.Drawing.Size(115, 111);
            this.panel_delete_client.TabIndex = 35;
            // 
            // enter_id_label
            // 
            this.enter_id_label.AutoSize = true;
            this.enter_id_label.Location = new System.Drawing.Point(36, 7);
            this.enter_id_label.Name = "enter_id_label";
            this.enter_id_label.Size = new System.Drawing.Size(53, 13);
            this.enter_id_label.TabIndex = 26;
            this.enter_id_label.Text = "הכנס ת\"ז";
            // 
            // delete_c
            // 
            this.delete_c.Location = new System.Drawing.Point(39, 70);
            this.delete_c.Name = "delete_c";
            this.delete_c.Size = new System.Drawing.Size(53, 28);
            this.delete_c.TabIndex = 28;
            this.delete_c.Text = "מחק";
            this.delete_c.UseVisualStyleBackColor = true;
            this.delete_c.Click += new System.EventHandler(this.delete_c_Click);
            // 
            // client_delete_text
            // 
            this.client_delete_text.Location = new System.Drawing.Point(22, 32);
            this.client_delete_text.Name = "client_delete_text";
            this.client_delete_text.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.client_delete_text.Size = new System.Drawing.Size(70, 20);
            this.client_delete_text.TabIndex = 25;
            // 
            // Update_c_btn
            // 
            this.Update_c_btn.Location = new System.Drawing.Point(587, 350);
            this.Update_c_btn.Name = "Update_c_btn";
            this.Update_c_btn.Size = new System.Drawing.Size(119, 26);
            this.Update_c_btn.TabIndex = 44;
            this.Update_c_btn.Text = "עדכון פרטי לקוח";
            this.Update_c_btn.UseVisualStyleBackColor = true;
            this.Update_c_btn.Click += new System.EventHandler(this.Update_c_btn_Click);
            // 
            // Update_p_btn
            // 
            this.Update_p_btn.Location = new System.Drawing.Point(748, 350);
            this.Update_p_btn.Name = "Update_p_btn";
            this.Update_p_btn.Size = new System.Drawing.Size(129, 26);
            this.Update_p_btn.TabIndex = 45;
            this.Update_p_btn.Text = "עדכון פרטי רוקח";
            this.Update_p_btn.UseVisualStyleBackColor = true;
            this.Update_p_btn.Click += new System.EventHandler(this.Update_p_btn_Click);
            // 
            // panel_update_c
            // 
            this.panel_update_c.Controls.Add(this.Update_c_id_txt);
            this.panel_update_c.Controls.Add(this.label3);
            this.panel_update_c.Controls.Add(this.radioBtn_c_LN);
            this.panel_update_c.Controls.Add(this.radioBtn_c_FN);
            this.panel_update_c.Controls.Add(this.radioBtn_c_PN);
            this.panel_update_c.Controls.Add(this.Update_now_c_btn);
            this.panel_update_c.Controls.Add(this.c_update_txt);
            this.panel_update_c.Location = new System.Drawing.Point(587, 375);
            this.panel_update_c.Name = "panel_update_c";
            this.panel_update_c.Size = new System.Drawing.Size(119, 201);
            this.panel_update_c.TabIndex = 43;
            // 
            // Update_c_id_txt
            // 
            this.Update_c_id_txt.Location = new System.Drawing.Point(12, 29);
            this.Update_c_id_txt.MaxLength = 20;
            this.Update_c_id_txt.Name = "Update_c_id_txt";
            this.Update_c_id_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Update_c_id_txt.Size = new System.Drawing.Size(100, 20);
            this.Update_c_id_txt.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "הכנס ת\"ז";
            // 
            // radioBtn_c_LN
            // 
            this.radioBtn_c_LN.AutoSize = true;
            this.radioBtn_c_LN.Location = new System.Drawing.Point(31, 114);
            this.radioBtn_c_LN.Name = "radioBtn_c_LN";
            this.radioBtn_c_LN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioBtn_c_LN.Size = new System.Drawing.Size(81, 17);
            this.radioBtn_c_LN.TabIndex = 44;
            this.radioBtn_c_LN.TabStop = true;
            this.radioBtn_c_LN.Text = "שם משפחה";
            this.radioBtn_c_LN.UseVisualStyleBackColor = true;
            // 
            // radioBtn_c_FN
            // 
            this.radioBtn_c_FN.AutoSize = true;
            this.radioBtn_c_FN.Location = new System.Drawing.Point(43, 91);
            this.radioBtn_c_FN.Name = "radioBtn_c_FN";
            this.radioBtn_c_FN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioBtn_c_FN.Size = new System.Drawing.Size(69, 17);
            this.radioBtn_c_FN.TabIndex = 43;
            this.radioBtn_c_FN.TabStop = true;
            this.radioBtn_c_FN.Text = "שם פרטי";
            this.radioBtn_c_FN.UseVisualStyleBackColor = true;
            // 
            // radioBtn_c_PN
            // 
            this.radioBtn_c_PN.AutoSize = true;
            this.radioBtn_c_PN.Location = new System.Drawing.Point(18, 68);
            this.radioBtn_c_PN.Name = "radioBtn_c_PN";
            this.radioBtn_c_PN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioBtn_c_PN.Size = new System.Drawing.Size(94, 17);
            this.radioBtn_c_PN.TabIndex = 42;
            this.radioBtn_c_PN.TabStop = true;
            this.radioBtn_c_PN.Text = "מספר פלאפון";
            this.radioBtn_c_PN.UseVisualStyleBackColor = true;
            // 
            // Update_now_c_btn
            // 
            this.Update_now_c_btn.Location = new System.Drawing.Point(25, 170);
            this.Update_now_c_btn.Name = "Update_now_c_btn";
            this.Update_now_c_btn.Size = new System.Drawing.Size(75, 27);
            this.Update_now_c_btn.TabIndex = 21;
            this.Update_now_c_btn.Text = "עדכן";
            this.Update_now_c_btn.UseVisualStyleBackColor = true;
            this.Update_now_c_btn.Click += new System.EventHandler(this.Update_now_c_btn_Click);
            // 
            // c_update_txt
            // 
            this.c_update_txt.Location = new System.Drawing.Point(16, 144);
            this.c_update_txt.MaxLength = 20;
            this.c_update_txt.Name = "c_update_txt";
            this.c_update_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.c_update_txt.Size = new System.Drawing.Size(100, 20);
            this.c_update_txt.TabIndex = 41;
            // 
            // panel_update_p
            // 
            this.panel_update_p.Controls.Add(this.Update_p_id_txt);
            this.panel_update_p.Controls.Add(this.label2);
            this.panel_update_p.Controls.Add(this.radioBtn_p_FN);
            this.panel_update_p.Controls.Add(this.radioBtn_p_LN);
            this.panel_update_p.Controls.Add(this.Update_now_p_btn);
            this.panel_update_p.Controls.Add(this.p_update_txt);
            this.panel_update_p.Location = new System.Drawing.Point(748, 378);
            this.panel_update_p.Name = "panel_update_p";
            this.panel_update_p.Size = new System.Drawing.Size(129, 198);
            this.panel_update_p.TabIndex = 34;
            // 
            // Update_p_id_txt
            // 
            this.Update_p_id_txt.Location = new System.Drawing.Point(12, 26);
            this.Update_p_id_txt.MaxLength = 20;
            this.Update_p_id_txt.Name = "Update_p_id_txt";
            this.Update_p_id_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Update_p_id_txt.Size = new System.Drawing.Size(100, 20);
            this.Update_p_id_txt.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "הכנס מס\' זיהוי";
            // 
            // radioBtn_p_FN
            // 
            this.radioBtn_p_FN.AutoSize = true;
            this.radioBtn_p_FN.Location = new System.Drawing.Point(33, 77);
            this.radioBtn_p_FN.Name = "radioBtn_p_FN";
            this.radioBtn_p_FN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioBtn_p_FN.Size = new System.Drawing.Size(69, 17);
            this.radioBtn_p_FN.TabIndex = 44;
            this.radioBtn_p_FN.TabStop = true;
            this.radioBtn_p_FN.Text = "שם פרטי";
            this.radioBtn_p_FN.UseVisualStyleBackColor = true;
            // 
            // radioBtn_p_LN
            // 
            this.radioBtn_p_LN.AutoSize = true;
            this.radioBtn_p_LN.Location = new System.Drawing.Point(21, 111);
            this.radioBtn_p_LN.Name = "radioBtn_p_LN";
            this.radioBtn_p_LN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioBtn_p_LN.Size = new System.Drawing.Size(81, 17);
            this.radioBtn_p_LN.TabIndex = 43;
            this.radioBtn_p_LN.TabStop = true;
            this.radioBtn_p_LN.Text = "שם משפחה";
            this.radioBtn_p_LN.UseVisualStyleBackColor = true;
            // 
            // Update_now_p_btn
            // 
            this.Update_now_p_btn.Location = new System.Drawing.Point(27, 167);
            this.Update_now_p_btn.Name = "Update_now_p_btn";
            this.Update_now_p_btn.Size = new System.Drawing.Size(75, 27);
            this.Update_now_p_btn.TabIndex = 19;
            this.Update_now_p_btn.Text = "עדכן";
            this.Update_now_p_btn.UseVisualStyleBackColor = true;
            this.Update_now_p_btn.Click += new System.EventHandler(this.Update_now_p_btn_Click);
            // 
            // p_update_txt
            // 
            this.p_update_txt.Location = new System.Drawing.Point(12, 141);
            this.p_update_txt.Name = "p_update_txt";
            this.p_update_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.p_update_txt.Size = new System.Drawing.Size(100, 20);
            this.p_update_txt.TabIndex = 13;
            // 
            // Update_btn
            // 
            this.Update_btn.Location = new System.Drawing.Point(641, 318);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(178, 26);
            this.Update_btn.TabIndex = 46;
            this.Update_btn.Text = "עדכון פרטים";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // Cancel_update_btn
            // 
            this.Cancel_update_btn.Location = new System.Drawing.Point(694, 585);
            this.Cancel_update_btn.Name = "Cancel_update_btn";
            this.Cancel_update_btn.Size = new System.Drawing.Size(56, 26);
            this.Cancel_update_btn.TabIndex = 47;
            this.Cancel_update_btn.Text = "ביטול";
            this.Cancel_update_btn.UseVisualStyleBackColor = true;
            this.Cancel_update_btn.Click += new System.EventHandler(this.Cancel_update_btn_Click);
            // 
            // errorProvider_id
            // 
            this.errorProvider_id.ContainerControl = this;
            // 
            // errorProvider_phone
            // 
            this.errorProvider_phone.ContainerControl = this;
            // 
            // server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(913, 617);
            this.Controls.Add(this.Cancel_update_btn);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.panel_update_p);
            this.Controls.Add(this.panel_update_c);
            this.Controls.Add(this.Update_p_btn);
            this.Controls.Add(this.Update_c_btn);
            this.Controls.Add(this.panel_delete_client);
            this.Controls.Add(this.delete_client);
            this.Controls.Add(this.panel_Client);
            this.Controls.Add(this.OpenClient);
            this.Controls.Add(this.panel_delete_pharmacist);
            this.Controls.Add(this.panel_delete_medicine);
            this.Controls.Add(this.panel_Pharmacist);
            this.Controls.Add(this.panel_Medicine);
            this.Controls.Add(this.Cancel_Delete);
            this.Controls.Add(this.Delete_Pharmacist);
            this.Controls.Add(this.Delete_Medicine);
            this.Controls.Add(this.Delete_Pharmacist_Medicine);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.OpenPharmacist);
            this.Controls.Add(this.OpenMedicine);
            this.Controls.Add(this.Add_Medicine_or_Pharmacist);
            this.Controls.Add(this.Llisten);
            this.Controls.Add(this.cancelListen);
            this.Controls.Add(this.startListen);
            this.Name = "server";
            this.Text = "server_side";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.server_FormClosing);
            this.Load += new System.EventHandler(this.server_Load);
            this.panel_Medicine.ResumeLayout(false);
            this.panel_Medicine.PerformLayout();
            this.panel_Pharmacist.ResumeLayout(false);
            this.panel_Pharmacist.PerformLayout();
            this.panel_delete_medicine.ResumeLayout(false);
            this.panel_delete_medicine.PerformLayout();
            this.panel_delete_pharmacist.ResumeLayout(false);
            this.panel_delete_pharmacist.PerformLayout();
            this.panel_Client.ResumeLayout(false);
            this.panel_Client.PerformLayout();
            this.panel_delete_client.ResumeLayout(false);
            this.panel_delete_client.PerformLayout();
            this.panel_update_c.ResumeLayout(false);
            this.panel_update_c.PerformLayout();
            this.panel_update_p.ResumeLayout(false);
            this.panel_update_p.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_phone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startListen;
        private System.Windows.Forms.Button cancelListen;
        private System.Windows.Forms.Label Llisten;
        private System.Windows.Forms.Button Add_Medicine_or_Pharmacist;
        private System.Windows.Forms.Button OpenMedicine;
        private System.Windows.Forms.Button OpenPharmacist;
        private System.Windows.Forms.Button AddMedicine;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox BrandName_Text;
        private System.Windows.Forms.TextBox MedType_Text;
        private System.Windows.Forms.TextBox GenericName_Text;
        private System.Windows.Forms.Label GenericName_label;
        private System.Windows.Forms.Label BrandName_label;
        private System.Windows.Forms.Label MedType_label;
        private System.Windows.Forms.TextBox Pharmacist_FName;
        private System.Windows.Forms.TextBox Pharmacist_LName;
        private System.Windows.Forms.Label L_P_FN;
        private System.Windows.Forms.Label C_PN_L;
        private System.Windows.Forms.Button AddPharmacist;
        private System.Windows.Forms.Button Delete_Pharmacist_Medicine;
        private System.Windows.Forms.Button Delete_Medicine;
        private System.Windows.Forms.Button Delete_Pharmacist;
        private System.Windows.Forms.TextBox Id_pharmacist_text;
        private System.Windows.Forms.TextBox Medicine_brand_text;
        private System.Windows.Forms.Label Medicine_generic_for_delete;
        private System.Windows.Forms.Label ID_Pharmacist_for_delete;
        private System.Windows.Forms.Button delete_m;
        private System.Windows.Forms.Button Cancel_Delete;
        private System.Windows.Forms.Button Delete_p;
        private System.Windows.Forms.Label TakeOption_label;
        private System.Windows.Forms.TextBox TakeOption_Text;
        private System.Windows.Forms.Panel panel_Medicine;
        private System.Windows.Forms.Panel panel_Pharmacist;
        private System.Windows.Forms.Panel panel_delete_medicine;
        private System.Windows.Forms.Panel panel_delete_pharmacist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpenClient;
        private System.Windows.Forms.Label C_ID_L;
        private System.Windows.Forms.Label C_FN_L;
        private System.Windows.Forms.Label C_LN_L;
        private System.Windows.Forms.TextBox C_Id_txt;
        private System.Windows.Forms.TextBox C_PN_txt;
        private System.Windows.Forms.TextBox C_FN_txt;
        private System.Windows.Forms.TextBox C_LN_txt;
        private System.Windows.Forms.Button Add_c_btn;
        private System.Windows.Forms.Panel panel_Client;
        private System.Windows.Forms.Button delete_client;
        private System.Windows.Forms.Panel panel_delete_client;
        private System.Windows.Forms.Label enter_id_label;
        private System.Windows.Forms.Button delete_c;
        private System.Windows.Forms.TextBox client_delete_text;
        private System.Windows.Forms.Button Update_c_btn;
        private System.Windows.Forms.Button Update_p_btn;
        private System.Windows.Forms.Panel panel_update_c;
        private System.Windows.Forms.Button Update_now_c_btn;
        private System.Windows.Forms.TextBox c_update_txt;
        private System.Windows.Forms.Panel panel_update_p;
        private System.Windows.Forms.Button Update_now_p_btn;
        private System.Windows.Forms.TextBox p_update_txt;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Button Cancel_update_btn;
        private System.Windows.Forms.RadioButton radioBtn_c_LN;
        private System.Windows.Forms.RadioButton radioBtn_c_FN;
        private System.Windows.Forms.RadioButton radioBtn_c_PN;
        private System.Windows.Forms.RadioButton radioBtn_p_FN;
        private System.Windows.Forms.RadioButton radioBtn_p_LN;
        private System.Windows.Forms.TextBox Update_c_id_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Update_p_id_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider_id;
        private System.Windows.Forms.ErrorProvider errorProvider_phone;
    }
}

