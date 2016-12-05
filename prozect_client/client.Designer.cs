namespace prozect_client
{
    partial class client
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
            this.id = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.text_id = new System.Windows.Forms.TextBox();
            this.text_fName = new System.Windows.Forms.TextBox();
            this.text_lName = new System.Windows.Forms.TextBox();
            this.ConnectServer_SendData = new System.Windows.Forms.Button();
            this.pharmestic = new System.Windows.Forms.Label();
            this.client2 = new System.Windows.Forms.Label();
            this.NumOfDays = new System.Windows.Forms.Label();
            this.comboMed = new System.Windows.Forms.ComboBox();
            this.Med = new System.Windows.Forms.Label();
            this.MedAmount = new System.Windows.Forms.Label();
            this.Morning = new System.Windows.Forms.Label();
            this.Noon = new System.Windows.Forms.Label();
            this.Night = new System.Windows.Forms.Label();
            this.MorningText = new System.Windows.Forms.TextBox();
            this.NoonText = new System.Windows.Forms.TextBox();
            this.NightText = new System.Windows.Forms.TextBox();
            this.AddMedicine = new System.Windows.Forms.Button();
            this.paneldays = new System.Windows.Forms.Panel();
            this.errorProvider_trofot = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorId = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_date = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.old_client = new System.Windows.Forms.Button();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.PhoneNumberText = new System.Windows.Forms.TextBox();
            this.Id_old_client_text = new System.Windows.Forms.TextBox();
            this.Search_client = new System.Windows.Forms.Button();
            this.Id_old_client_label = new System.Windows.Forms.Label();
            this.SearchClientPanel = new System.Windows.Forms.Panel();
            this.Pharmacist_txt = new System.Windows.Forms.TextBox();
            this.Enter_Pharmacist = new System.Windows.Forms.Label();
            this.Pharmacist_number_txt = new System.Windows.Forms.TextBox();
            this.bring_p_btn = new System.Windows.Forms.Button();
            this.change_p_btn = new System.Windows.Forms.Button();
            this.Client_Label = new System.Windows.Forms.Label();
            this.NumOfDays_txt = new System.Windows.Forms.TextBox();
            this.paneldays.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_trofot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_date)).BeginInit();
            this.SearchClientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(664, 108);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(24, 13);
            this.id.TabIndex = 0;
            this.id.Text = "ת\"ז";
            // 
            // fName
            // 
            this.fName.AutoSize = true;
            this.fName.Location = new System.Drawing.Point(666, 192);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(51, 13);
            this.fName.TabIndex = 0;
            this.fName.Text = "שם פרטי";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(666, 233);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(63, 13);
            this.lName.TabIndex = 0;
            this.lName.Text = "שם משפחה";
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(500, 101);
            this.text_id.MaxLength = 9;
            this.text_id.Name = "text_id";
            this.text_id.ReadOnly = true;
            this.text_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_id.Size = new System.Drawing.Size(154, 20);
            this.text_id.TabIndex = 1;
            // 
            // text_fName
            // 
            this.text_fName.Location = new System.Drawing.Point(501, 185);
            this.text_fName.MaxLength = 20;
            this.text_fName.Name = "text_fName";
            this.text_fName.ReadOnly = true;
            this.text_fName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_fName.Size = new System.Drawing.Size(154, 20);
            this.text_fName.TabIndex = 2;
            // 
            // text_lName
            // 
            this.text_lName.Location = new System.Drawing.Point(500, 226);
            this.text_lName.MaxLength = 20;
            this.text_lName.Name = "text_lName";
            this.text_lName.ReadOnly = true;
            this.text_lName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_lName.Size = new System.Drawing.Size(154, 20);
            this.text_lName.TabIndex = 3;
            // 
            // ConnectServer_SendData
            // 
            this.ConnectServer_SendData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ConnectServer_SendData.Location = new System.Drawing.Point(337, 286);
            this.ConnectServer_SendData.Name = "ConnectServer_SendData";
            this.ConnectServer_SendData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ConnectServer_SendData.Size = new System.Drawing.Size(58, 26);
            this.ConnectServer_SendData.TabIndex = 0;
            this.ConnectServer_SendData.TabStop = false;
            this.ConnectServer_SendData.Text = "שלח";
            this.ConnectServer_SendData.UseVisualStyleBackColor = true;
            this.ConnectServer_SendData.Click += new System.EventHandler(this.ConnectServer_SendData_Click);
            // 
            // pharmestic
            // 
            this.pharmestic.AutoSize = true;
            this.pharmestic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.pharmestic.Location = new System.Drawing.Point(660, 57);
            this.pharmestic.Name = "pharmestic";
            this.pharmestic.Size = new System.Drawing.Size(32, 13);
            this.pharmestic.TabIndex = 0;
            this.pharmestic.Text = "רוקח";
            // 
            // client2
            // 
            this.client2.AutoSize = true;
            this.client2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.client2.Location = new System.Drawing.Point(308, 1);
            this.client2.Name = "client2";
            this.client2.Size = new System.Drawing.Size(45, 13);
            this.client2.TabIndex = 0;
            this.client2.Text = "מטופל";
            // 
            // NumOfDays
            // 
            this.NumOfDays.AutoSize = true;
            this.NumOfDays.Location = new System.Drawing.Point(667, 271);
            this.NumOfDays.Name = "NumOfDays";
            this.NumOfDays.Size = new System.Drawing.Size(50, 13);
            this.NumOfDays.TabIndex = 0;
            this.NumOfDays.Text = "מס\' ימים";
            // 
            // comboMed
            // 
            this.comboMed.FormattingEnabled = true;
            this.comboMed.Location = new System.Drawing.Point(268, 32);
            this.comboMed.Name = "comboMed";
            this.comboMed.Size = new System.Drawing.Size(121, 21);
            this.comboMed.Sorted = true;
            this.comboMed.TabIndex = 6;
            // 
            // Med
            // 
            this.Med.AutoSize = true;
            this.Med.Location = new System.Drawing.Point(395, 35);
            this.Med.Name = "Med";
            this.Med.Size = new System.Drawing.Size(39, 13);
            this.Med.TabIndex = 0;
            this.Med.Text = "תרופה";
            // 
            // MedAmount
            // 
            this.MedAmount.AutoSize = true;
            this.MedAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.MedAmount.Location = new System.Drawing.Point(282, 71);
            this.MedAmount.Name = "MedAmount";
            this.MedAmount.Size = new System.Drawing.Size(103, 17);
            this.MedAmount.TabIndex = 0;
            this.MedAmount.Text = "כמות כדורים ליום";
            // 
            // Morning
            // 
            this.Morning.AutoSize = true;
            this.Morning.Location = new System.Drawing.Point(117, 5);
            this.Morning.Name = "Morning";
            this.Morning.Size = new System.Drawing.Size(32, 13);
            this.Morning.TabIndex = 0;
            this.Morning.Text = "בוקר";
            // 
            // Noon
            // 
            this.Noon.AutoSize = true;
            this.Noon.Location = new System.Drawing.Point(59, 5);
            this.Noon.Name = "Noon";
            this.Noon.Size = new System.Drawing.Size(44, 13);
            this.Noon.TabIndex = 0;
            this.Noon.Text = "צהריים";
            // 
            // Night
            // 
            this.Night.AutoSize = true;
            this.Night.Location = new System.Drawing.Point(15, 5);
            this.Night.Name = "Night";
            this.Night.Size = new System.Drawing.Size(33, 13);
            this.Night.TabIndex = 0;
            this.Night.Text = "לילה";
            // 
            // MorningText
            // 
            this.MorningText.Location = new System.Drawing.Point(121, 26);
            this.MorningText.Name = "MorningText";
            this.MorningText.Size = new System.Drawing.Size(20, 20);
            this.MorningText.TabIndex = 7;
            // 
            // NoonText
            // 
            this.NoonText.Location = new System.Drawing.Point(72, 26);
            this.NoonText.Name = "NoonText";
            this.NoonText.Size = new System.Drawing.Size(20, 20);
            this.NoonText.TabIndex = 8;
            // 
            // NightText
            // 
            this.NightText.Location = new System.Drawing.Point(18, 26);
            this.NightText.Name = "NightText";
            this.NightText.Size = new System.Drawing.Size(20, 20);
            this.NightText.TabIndex = 9;
            // 
            // AddMedicine
            // 
            this.AddMedicine.Location = new System.Drawing.Point(239, 286);
            this.AddMedicine.Name = "AddMedicine";
            this.AddMedicine.Size = new System.Drawing.Size(81, 26);
            this.AddMedicine.TabIndex = 0;
            this.AddMedicine.TabStop = false;
            this.AddMedicine.Text = "הוסף תרופה";
            this.AddMedicine.UseVisualStyleBackColor = true;
            this.AddMedicine.Click += new System.EventHandler(this.AddMedicine_Click_1);
            // 
            // paneldays
            // 
            this.paneldays.Controls.Add(this.NightText);
            this.paneldays.Controls.Add(this.NoonText);
            this.paneldays.Controls.Add(this.MorningText);
            this.paneldays.Controls.Add(this.Night);
            this.paneldays.Controls.Add(this.Noon);
            this.paneldays.Controls.Add(this.Morning);
            this.paneldays.Location = new System.Drawing.Point(250, 96);
            this.paneldays.Name = "paneldays";
            this.paneldays.Size = new System.Drawing.Size(173, 50);
            this.paneldays.TabIndex = 49;
            // 
            // errorProvider_trofot
            // 
            this.errorProvider_trofot.BlinkRate = 0;
            this.errorProvider_trofot.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider_trofot.ContainerControl = this;
            this.errorProvider_trofot.RightToLeft = true;
            // 
            // errorId
            // 
            this.errorId.ContainerControl = this;
            // 
            // errorProvider_date
            // 
            this.errorProvider_date.ContainerControl = this;
            this.errorProvider_date.RightToLeft = true;
            this.errorProvider_date.RightToLeftChanged += new System.EventHandler(this.ConnectServer_SendData_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 1);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(84, 20);
            this.dateTimePicker1.TabIndex = 50;
            this.dateTimePicker1.Value = new System.DateTime(2016, 11, 6, 8, 18, 54, 0);
            // 
            // old_client
            // 
            this.old_client.Location = new System.Drawing.Point(89, 33);
            this.old_client.Name = "old_client";
            this.old_client.Size = new System.Drawing.Size(80, 23);
            this.old_client.TabIndex = 52;
            this.old_client.Text = "לקוח קיים";
            this.old_client.UseVisualStyleBackColor = true;
            this.old_client.Click += new System.EventHandler(this.old_client_Click);
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Location = new System.Drawing.Point(664, 152);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(65, 13);
            this.PhoneNumber.TabIndex = 53;
            this.PhoneNumber.Text = "מס\' פלאפון";
            // 
            // PhoneNumberText
            // 
            this.PhoneNumberText.Location = new System.Drawing.Point(500, 145);
            this.PhoneNumberText.MaxLength = 9;
            this.PhoneNumberText.Name = "PhoneNumberText";
            this.PhoneNumberText.ReadOnly = true;
            this.PhoneNumberText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PhoneNumberText.Size = new System.Drawing.Size(154, 20);
            this.PhoneNumberText.TabIndex = 54;
            // 
            // Id_old_client_text
            // 
            this.Id_old_client_text.Location = new System.Drawing.Point(0, 8);
            this.Id_old_client_text.MaxLength = 9;
            this.Id_old_client_text.Name = "Id_old_client_text";
            this.Id_old_client_text.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Id_old_client_text.Size = new System.Drawing.Size(154, 20);
            this.Id_old_client_text.TabIndex = 55;
            this.Id_old_client_text.TextChanged += new System.EventHandler(this.Id_old_client_text_TextChanged);
            this.Id_old_client_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Id_old_client_text_KeyDown);
            // 
            // Search_client
            // 
            this.Search_client.Location = new System.Drawing.Point(74, 33);
            this.Search_client.Name = "Search_client";
            this.Search_client.Size = new System.Drawing.Size(80, 23);
            this.Search_client.TabIndex = 56;
            this.Search_client.Text = "חפש לקוח";
            this.Search_client.UseVisualStyleBackColor = true;
            this.Search_client.Click += new System.EventHandler(this.Search_client_Click);
            // 
            // Id_old_client_label
            // 
            this.Id_old_client_label.AutoSize = true;
            this.Id_old_client_label.Location = new System.Drawing.Point(160, 16);
            this.Id_old_client_label.Name = "Id_old_client_label";
            this.Id_old_client_label.Size = new System.Drawing.Size(24, 13);
            this.Id_old_client_label.TabIndex = 62;
            this.Id_old_client_label.Text = "ת\"ז";
            // 
            // SearchClientPanel
            // 
            this.SearchClientPanel.Controls.Add(this.Id_old_client_label);
            this.SearchClientPanel.Controls.Add(this.Search_client);
            this.SearchClientPanel.Controls.Add(this.Id_old_client_text);
            this.SearchClientPanel.Location = new System.Drawing.Point(15, 54);
            this.SearchClientPanel.Name = "SearchClientPanel";
            this.SearchClientPanel.Size = new System.Drawing.Size(229, 60);
            this.SearchClientPanel.TabIndex = 68;
            // 
            // Pharmacist_txt
            // 
            this.Pharmacist_txt.Location = new System.Drawing.Point(500, 54);
            this.Pharmacist_txt.MaxLength = 9;
            this.Pharmacist_txt.Name = "Pharmacist_txt";
            this.Pharmacist_txt.ReadOnly = true;
            this.Pharmacist_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Pharmacist_txt.Size = new System.Drawing.Size(154, 20);
            this.Pharmacist_txt.TabIndex = 69;
            // 
            // Enter_Pharmacist
            // 
            this.Enter_Pharmacist.AutoSize = true;
            this.Enter_Pharmacist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Enter_Pharmacist.Location = new System.Drawing.Point(656, 23);
            this.Enter_Pharmacist.Name = "Enter_Pharmacist";
            this.Enter_Pharmacist.Size = new System.Drawing.Size(78, 13);
            this.Enter_Pharmacist.TabIndex = 70;
            this.Enter_Pharmacist.Text = "הכנסת רוקח";
            // 
            // Pharmacist_number_txt
            // 
            this.Pharmacist_number_txt.Location = new System.Drawing.Point(596, 20);
            this.Pharmacist_number_txt.MaxLength = 9;
            this.Pharmacist_number_txt.Name = "Pharmacist_number_txt";
            this.Pharmacist_number_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Pharmacist_number_txt.Size = new System.Drawing.Size(58, 20);
            this.Pharmacist_number_txt.TabIndex = 63;
            this.Pharmacist_number_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pharmacist_number_txt_KeyDown);
            // 
            // bring_p_btn
            // 
            this.bring_p_btn.Location = new System.Drawing.Point(546, 17);
            this.bring_p_btn.Name = "bring_p_btn";
            this.bring_p_btn.Size = new System.Drawing.Size(44, 23);
            this.bring_p_btn.TabIndex = 63;
            this.bring_p_btn.Text = "ייבא";
            this.bring_p_btn.UseVisualStyleBackColor = true;
            this.bring_p_btn.Click += new System.EventHandler(this.bring_p_btn_Click);
            // 
            // change_p_btn
            // 
            this.change_p_btn.Location = new System.Drawing.Point(500, 17);
            this.change_p_btn.Name = "change_p_btn";
            this.change_p_btn.Size = new System.Drawing.Size(45, 23);
            this.change_p_btn.TabIndex = 63;
            this.change_p_btn.Text = "החלף";
            this.change_p_btn.UseVisualStyleBackColor = true;
            this.change_p_btn.Click += new System.EventHandler(this.change_p_btn_Click);
            // 
            // Client_Label
            // 
            this.Client_Label.AutoSize = true;
            this.Client_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Client_Label.Location = new System.Drawing.Point(564, 82);
            this.Client_Label.Name = "Client_Label";
            this.Client_Label.Size = new System.Drawing.Size(37, 13);
            this.Client_Label.TabIndex = 71;
            this.Client_Label.Text = "לקוח";
            // 
            // NumOfDays_txt
            // 
            this.NumOfDays_txt.Location = new System.Drawing.Point(500, 264);
            this.NumOfDays_txt.MaxLength = 2;
            this.NumOfDays_txt.Name = "NumOfDays_txt";
            this.NumOfDays_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NumOfDays_txt.Size = new System.Drawing.Size(154, 20);
            this.NumOfDays_txt.TabIndex = 63;
            this.NumOfDays_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumOfDays_txt_KeyDown);
            // 
            // client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(743, 324);
            this.Controls.Add(this.NumOfDays_txt);
            this.Controls.Add(this.Client_Label);
            this.Controls.Add(this.change_p_btn);
            this.Controls.Add(this.bring_p_btn);
            this.Controls.Add(this.Pharmacist_number_txt);
            this.Controls.Add(this.Enter_Pharmacist);
            this.Controls.Add(this.Pharmacist_txt);
            this.Controls.Add(this.SearchClientPanel);
            this.Controls.Add(this.PhoneNumberText);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.old_client);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.paneldays);
            this.Controls.Add(this.AddMedicine);
            this.Controls.Add(this.MedAmount);
            this.Controls.Add(this.Med);
            this.Controls.Add(this.comboMed);
            this.Controls.Add(this.NumOfDays);
            this.Controls.Add(this.client2);
            this.Controls.Add(this.pharmestic);
            this.Controls.Add(this.ConnectServer_SendData);
            this.Controls.Add(this.text_lName);
            this.Controls.Add(this.text_fName);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.id);
            this.Name = "client";
            this.Text = "Trofot-x";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.client_FormClosing);
            this.Load += new System.EventHandler(this.client_Load);
            this.paneldays.ResumeLayout(false);
            this.paneldays.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_trofot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_date)).EndInit();
            this.SearchClientPanel.ResumeLayout(false);
            this.SearchClientPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label id;
        public System.Windows.Forms.Label fName;
        public System.Windows.Forms.Label lName;
        public System.Windows.Forms.TextBox text_id;
        public System.Windows.Forms.TextBox text_fName;
        public System.Windows.Forms.TextBox text_lName;
        public System.Windows.Forms.Button ConnectServer_SendData;
        public System.Windows.Forms.Label pharmestic;
        public System.Windows.Forms.Label client2;
        public System.Windows.Forms.Label NumOfDays;
        public System.Windows.Forms.ComboBox comboMed;
        public System.Windows.Forms.Label Med;
        public System.Windows.Forms.Label MedAmount;
        public System.Windows.Forms.Label Noon;
        public System.Windows.Forms.Label Night;
        public System.Windows.Forms.TextBox MorningText;
        public System.Windows.Forms.TextBox NoonText;
        public System.Windows.Forms.TextBox NightText;
        public System.Windows.Forms.Button AddMedicine;
        public System.Windows.Forms.Label Morning;
        public System.Windows.Forms.Panel paneldays;
        private System.Windows.Forms.ErrorProvider errorProvider_trofot;
        private System.Windows.Forms.ErrorProvider errorId;
        private System.Windows.Forms.ErrorProvider errorProvider_date;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button old_client;
        public System.Windows.Forms.Label PhoneNumber;
        public System.Windows.Forms.TextBox PhoneNumberText;
        public System.Windows.Forms.Label Id_old_client_label;
        private System.Windows.Forms.Button Search_client;
        public System.Windows.Forms.TextBox Id_old_client_text;
        public System.Windows.Forms.Panel SearchClientPanel;
        public System.Windows.Forms.TextBox Pharmacist_txt;
        private System.Windows.Forms.Button bring_p_btn;
        public System.Windows.Forms.TextBox Pharmacist_number_txt;
        public System.Windows.Forms.Label Enter_Pharmacist;
        public System.Windows.Forms.Button change_p_btn;
        public System.Windows.Forms.TextBox NumOfDays_txt;
        private System.Windows.Forms.Label Client_Label;
    }
}

