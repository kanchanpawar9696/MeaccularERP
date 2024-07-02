namespace MeaccularERP
{
    partial class frm_login
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
            this.lbl_usedid = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_useid = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_forgetpwd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_usedid
            // 
            this.lbl_usedid.AutoSize = true;
            this.lbl_usedid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usedid.Location = new System.Drawing.Point(59, 45);
            this.lbl_usedid.Name = "lbl_usedid";
            this.lbl_usedid.Size = new System.Drawing.Size(82, 16);
            this.lbl_usedid.TabIndex = 0;
            this.lbl_usedid.Text = "UserName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Password";
            // 
            // txt_useid
            // 
            this.txt_useid.Location = new System.Drawing.Point(152, 48);
            this.txt_useid.Name = "txt_useid";
            this.txt_useid.Size = new System.Drawing.Size(154, 20);
            this.txt_useid.TabIndex = 2;
            this.txt_useid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_useid_KeyDown);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(152, 93);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(154, 20);
            this.txt_password.TabIndex = 3;
            this.txt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_password_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(275, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Login";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(253, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 6;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(49, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_forgetpwd);
            this.panel1.Controls.Add(this.lbl_usedid);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.txt_useid);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Location = new System.Drawing.Point(127, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 246);
            this.panel1.TabIndex = 11;
            // 
            // btn_forgetpwd
            // 
            this.btn_forgetpwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_forgetpwd.Location = new System.Drawing.Point(133, 148);
            this.btn_forgetpwd.Name = "btn_forgetpwd";
            this.btn_forgetpwd.Size = new System.Drawing.Size(114, 33);
            this.btn_forgetpwd.TabIndex = 7;
            this.btn_forgetpwd.Text = "Forget Password";
            this.btn_forgetpwd.UseVisualStyleBackColor = true;
            this.btn_forgetpwd.Click += new System.EventHandler(this.btn_forgetpwd_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_login";
            this.Text = "frm_login";
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_usedid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_useid;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_forgetpwd;
    }
}