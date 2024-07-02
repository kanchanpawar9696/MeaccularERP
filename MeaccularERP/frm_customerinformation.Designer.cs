namespace MeaccularERP
{
    partial class frm_customerinformation
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
            this.txt_pin = new System.Windows.Forms.TextBox();
            this.Label19 = new System.Windows.Forms.Label();
            this.txt_state = new System.Windows.Forms.ComboBox();
            this.txt_AadhaarNo = new System.Windows.Forms.TextBox();
            this.Label33 = new System.Windows.Forms.Label();
            this.cmb_district = new System.Windows.Forms.ComboBox();
            this.Label31 = new System.Windows.Forms.Label();
            this.cmb_taluka = new System.Windows.Forms.ComboBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.dtp_birthdate = new System.Windows.Forms.DateTimePicker();
            this.Label26 = new System.Windows.Forms.Label();
            this.txt_mobileno = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.btn_allcust = new System.Windows.Forms.Button();
            this.lbl_accountcode = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.cmb_city = new System.Windows.Forms.ComboBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.Label72 = new System.Windows.Forms.Label();
            this.Label73 = new System.Windows.Forms.Label();
            this.txt_custname = new System.Windows.Forms.TextBox();
            this.txt_custcode = new System.Windows.Forms.TextBox();
            this.lst_custname = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_pin
            // 
            this.txt_pin.Location = new System.Drawing.Point(239, 277);
            this.txt_pin.Name = "txt_pin";
            this.txt_pin.Size = new System.Drawing.Size(168, 20);
            this.txt_pin.TabIndex = 260;
            this.txt_pin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_pin_KeyDown);
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Location = new System.Drawing.Point(174, 281);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(50, 13);
            this.Label19.TabIndex = 259;
            this.Label19.Text = "Pin Code";
            // 
            // txt_state
            // 
            this.txt_state.AccessibleName = "State";
            this.txt_state.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_state.FormattingEnabled = true;
            this.txt_state.Items.AddRange(new object[] {
            "01-Jammu and Kashmir",
            "02-Himachal Pradesh",
            "03-Punjab",
            "04-Chandigarh",
            "05-Uttarakhand",
            "06-Haryana",
            "07-Delhi",
            "08-Rajasthan",
            "09-Uttar Pradesh",
            "10-Bihar",
            "11-Sikkim",
            "12-Arunachal Pradesh",
            "13-Nagaland",
            "14-Manipur",
            "15-Mizoram",
            "16-Tripura",
            "17-Meghalaya",
            "18-Assam",
            "19-West Bengal",
            "20-Jharkhand",
            "21-Odisha",
            "22-Chhattisgarh",
            "23-Madhya Pradesh",
            "24-Gujarat",
            "25-Daman & Diu",
            "26-Dadra & Nagar Haveli",
            "27-Maharashtra",
            "29-Karnataka",
            "30-Goa",
            "31-Lakshdweep",
            "32-Kerala",
            "33-Tamil Nadu",
            "34-Pondicherry",
            "35-Andaman & Nicobar Islands",
            "36-Telangana",
            "37-Andhra Pradesh",
            "97-Other Territory",
            "",
            ""});
            this.txt_state.Location = new System.Drawing.Point(238, 253);
            this.txt_state.Name = "txt_state";
            this.txt_state.Size = new System.Drawing.Size(168, 21);
            this.txt_state.TabIndex = 240;
            this.txt_state.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_state_KeyDown);
            // 
            // txt_AadhaarNo
            // 
            this.txt_AadhaarNo.AccessibleName = "AadhaarNo";
            this.txt_AadhaarNo.Location = new System.Drawing.Point(239, 402);
            this.txt_AadhaarNo.Name = "txt_AadhaarNo";
            this.txt_AadhaarNo.Size = new System.Drawing.Size(168, 20);
            this.txt_AadhaarNo.TabIndex = 243;
            this.txt_AadhaarNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_AadhaarNo_KeyDown);
            // 
            // Label33
            // 
            this.Label33.AutoSize = true;
            this.Label33.Location = new System.Drawing.Point(164, 405);
            this.Label33.Name = "Label33";
            this.Label33.Size = new System.Drawing.Size(64, 13);
            this.Label33.TabIndex = 258;
            this.Label33.Text = "Aadhaar No";
            // 
            // cmb_district
            // 
            this.cmb_district.AccessibleName = "District";
            this.cmb_district.FormattingEnabled = true;
            this.cmb_district.Location = new System.Drawing.Point(238, 161);
            this.cmb_district.Name = "cmb_district";
            this.cmb_district.Size = new System.Drawing.Size(168, 21);
            this.cmb_district.Sorted = true;
            this.cmb_district.TabIndex = 256;
            this.cmb_district.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_district_KeyDown);
            // 
            // Label31
            // 
            this.Label31.AutoSize = true;
            this.Label31.Location = new System.Drawing.Point(190, 164);
            this.Label31.Name = "Label31";
            this.Label31.Size = new System.Drawing.Size(39, 13);
            this.Label31.TabIndex = 257;
            this.Label31.Text = "District";
            // 
            // cmb_taluka
            // 
            this.cmb_taluka.AccessibleName = "Taluka";
            this.cmb_taluka.FormattingEnabled = true;
            this.cmb_taluka.Location = new System.Drawing.Point(238, 192);
            this.cmb_taluka.Name = "cmb_taluka";
            this.cmb_taluka.Size = new System.Drawing.Size(168, 21);
            this.cmb_taluka.Sorted = true;
            this.cmb_taluka.TabIndex = 238;
            this.cmb_taluka.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_taluka_KeyDown);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(192, 195);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(40, 13);
            this.Label6.TabIndex = 255;
            this.Label6.Text = "Taluka";
            // 
            // dtp_birthdate
            // 
            this.dtp_birthdate.AccessibleName = "Birth Date";
            this.dtp_birthdate.Checked = false;
            this.dtp_birthdate.CustomFormat = "dd/MMM/yyyy";
            this.dtp_birthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_birthdate.Location = new System.Drawing.Point(239, 368);
            this.dtp_birthdate.Name = "dtp_birthdate";
            this.dtp_birthdate.ShowCheckBox = true;
            this.dtp_birthdate.Size = new System.Drawing.Size(168, 20);
            this.dtp_birthdate.TabIndex = 244;
            this.dtp_birthdate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_birthdate_KeyDown);
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.Location = new System.Drawing.Point(175, 371);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(54, 13);
            this.Label26.TabIndex = 254;
            this.Label26.Text = "Birth Date";
            // 
            // txt_mobileno
            // 
            this.txt_mobileno.AccessibleName = "Mobile No";
            this.txt_mobileno.Location = new System.Drawing.Point(239, 302);
            this.txt_mobileno.Name = "txt_mobileno";
            this.txt_mobileno.Size = new System.Drawing.Size(168, 20);
            this.txt_mobileno.TabIndex = 241;
            this.txt_mobileno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_mobileno_KeyDown);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(173, 305);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(55, 13);
            this.Label7.TabIndex = 253;
            this.Label7.Text = "Mobile No";
            // 
            // btn_allcust
            // 
            this.btn_allcust.AccessibleName = "All Customer";
            this.btn_allcust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_allcust.Location = new System.Drawing.Point(409, 107);
            this.btn_allcust.Name = "btn_allcust";
            this.btn_allcust.Size = new System.Drawing.Size(31, 23);
            this.btn_allcust.TabIndex = 252;
            this.btn_allcust.Text = "A";
            this.btn_allcust.UseVisualStyleBackColor = true;
            // 
            // lbl_accountcode
            // 
            this.lbl_accountcode.AutoSize = true;
            this.lbl_accountcode.Location = new System.Drawing.Point(415, 76);
            this.lbl_accountcode.Name = "lbl_accountcode";
            this.lbl_accountcode.Size = new System.Drawing.Size(0, 13);
            this.lbl_accountcode.TabIndex = 251;
            this.lbl_accountcode.Visible = false;
            // 
            // txt_email
            // 
            this.txt_email.AccessibleName = "Email";
            this.txt_email.Location = new System.Drawing.Point(239, 334);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(168, 20);
            this.txt_email.TabIndex = 242;
            this.txt_email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_email_KeyDown);
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(197, 337);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(32, 13);
            this.Label15.TabIndex = 250;
            this.Label15.Text = "Email";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(200, 257);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(32, 13);
            this.Label2.TabIndex = 249;
            this.Label2.Text = "State";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(208, 225);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(24, 13);
            this.Label1.TabIndex = 248;
            this.Label1.Text = "City";
            // 
            // cmb_city
            // 
            this.cmb_city.AccessibleName = "City";
            this.cmb_city.FormattingEnabled = true;
            this.cmb_city.Location = new System.Drawing.Point(238, 222);
            this.cmb_city.Name = "cmb_city";
            this.cmb_city.Size = new System.Drawing.Size(168, 21);
            this.cmb_city.Sorted = true;
            this.cmb_city.TabIndex = 239;
            this.cmb_city.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_city_KeyDown);
            // 
            // txt_address
            // 
            this.txt_address.AccessibleName = "Address";
            this.txt_address.Location = new System.Drawing.Point(238, 135);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(170, 19);
            this.txt_address.TabIndex = 236;
            this.txt_address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_address_KeyDown);
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(182, 138);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(45, 13);
            this.Address.TabIndex = 247;
            this.Address.Text = "Address";
            // 
            // Label72
            // 
            this.Label72.AutoSize = true;
            this.Label72.Location = new System.Drawing.Point(141, 81);
            this.Label72.Name = "Label72";
            this.Label72.Size = new System.Drawing.Size(79, 13);
            this.Label72.TabIndex = 245;
            this.Label72.Text = "Customer Code";
            this.Label72.Visible = false;
            // 
            // Label73
            // 
            this.Label73.AutoSize = true;
            this.Label73.Location = new System.Drawing.Point(137, 110);
            this.Label73.Name = "Label73";
            this.Label73.Size = new System.Drawing.Size(80, 13);
            this.Label73.TabIndex = 246;
            this.Label73.Text = "Customer name";
            // 
            // txt_custname
            // 
            this.txt_custname.AccessibleName = "Customer Name";
            this.txt_custname.BackColor = System.Drawing.Color.White;
            this.txt_custname.Location = new System.Drawing.Point(238, 107);
            this.txt_custname.Name = "txt_custname";
            this.txt_custname.Size = new System.Drawing.Size(170, 20);
            this.txt_custname.TabIndex = 235;
            this.txt_custname.TextChanged += new System.EventHandler(this.txt_custname_TextChanged);
            this.txt_custname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_custname_KeyDown);
            // 
            // txt_custcode
            // 
            this.txt_custcode.Location = new System.Drawing.Point(239, 78);
            this.txt_custcode.Name = "txt_custcode";
            this.txt_custcode.Size = new System.Drawing.Size(168, 20);
            this.txt_custcode.TabIndex = 234;
            // 
            // lst_custname
            // 
            this.lst_custname.FormattingEnabled = true;
            this.lst_custname.Location = new System.Drawing.Point(238, 128);
            this.lst_custname.Name = "lst_custname";
            this.lst_custname.Size = new System.Drawing.Size(299, 121);
            this.lst_custname.TabIndex = 237;
            this.lst_custname.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 24);
            this.label3.TabIndex = 261;
            this.label3.Text = "Customer Master";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(156, 453);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 33);
            this.btn_save.TabIndex = 262;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(320, 453);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 33);
            this.btn_delete.TabIndex = 263;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_modify
            // 
            this.btn_modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modify.Location = new System.Drawing.Point(239, 453);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(75, 33);
            this.btn_modify.TabIndex = 264;
            this.btn_modify.Text = "Modify";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(401, 453);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 33);
            this.btn_cancel.TabIndex = 265;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AccessibleName = "All Customer";
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(769, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 266;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_customerinformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_pin);
            this.Controls.Add(this.Label19);
            this.Controls.Add(this.txt_state);
            this.Controls.Add(this.txt_AadhaarNo);
            this.Controls.Add(this.Label33);
            this.Controls.Add(this.cmb_district);
            this.Controls.Add(this.Label31);
            this.Controls.Add(this.cmb_taluka);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.dtp_birthdate);
            this.Controls.Add(this.Label26);
            this.Controls.Add(this.txt_mobileno);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.btn_allcust);
            this.Controls.Add(this.lbl_accountcode);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cmb_city);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Label72);
            this.Controls.Add(this.Label73);
            this.Controls.Add(this.txt_custname);
            this.Controls.Add(this.txt_custcode);
            this.Controls.Add(this.lst_custname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_customerinformation";
            this.Text = "frm_customerinformation";
            this.Load += new System.EventHandler(this.frm_customerinformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txt_pin;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.ComboBox txt_state;
        internal System.Windows.Forms.TextBox txt_AadhaarNo;
        internal System.Windows.Forms.Label Label33;
        internal System.Windows.Forms.ComboBox cmb_district;
        internal System.Windows.Forms.Label Label31;
        internal System.Windows.Forms.ComboBox cmb_taluka;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.DateTimePicker dtp_birthdate;
        internal System.Windows.Forms.Label Label26;
        internal System.Windows.Forms.TextBox txt_mobileno;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button btn_allcust;
        internal System.Windows.Forms.Label lbl_accountcode;
        internal System.Windows.Forms.TextBox txt_email;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cmb_city;
        internal System.Windows.Forms.TextBox txt_address;
        internal System.Windows.Forms.Label Address;
        internal System.Windows.Forms.Label Label72;
        internal System.Windows.Forms.Label Label73;
        internal System.Windows.Forms.TextBox txt_custname;
        internal System.Windows.Forms.TextBox txt_custcode;
        internal System.Windows.Forms.ListBox lst_custname;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Button btn_cancel;
        internal System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}