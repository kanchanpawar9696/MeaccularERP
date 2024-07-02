using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Lifetime;

namespace MeaccularERP
{
    public partial class frm_forgetpassword : Form
    {
        Cls_main obj = new Cls_main();

        public frm_forgetpassword()
        {
            InitializeComponent();
        }

        private void btn_changepwd_Click(object sender, EventArgs e)
        {

         
                if (!string.IsNullOrWhiteSpace(txt_newpwd.Text))
                {
                    DataSet ds = obj.Read_table("SELECT * FROM Login where UserName='" + txt_username.Text + "' and  Mobile_No='" + txt_mobileno.Text + "'");

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE Login SET Password=@Password WHERE Username='" + txt_username.Text + "'and Mobile_No='" + txt_mobileno.Text + "'", obj.con);
                        cmd.Parameters.AddWithValue("@Password", txt_newpwd.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Password Updated Successfully", "Meassage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm_login objj = new frm_login();
                        frm_forgetpassword obj1 = new frm_forgetpassword();
                        objj.Show();
                        this.Hide();
                    }
                    else
                    {

                        MessageBox.Show("InCorrect Username And Mobileno", "Meassage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_username.Select();
                        txt_newpwd.Clear();
                        txt_mobileno.Clear();
                    }




                }
            }

        private void txt_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                txt_mobileno.Focus();


            }

        }

        private void txt_mobileno_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode ==Keys.Enter)
            {
                txt_newpwd.Focus();

            }
            
        }

        private void frm_forgetpassword_Load(object sender, EventArgs e)
        {
            txt_username.Select();
        }

        private void txt_newpwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                btn_changepwd.Focus();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            this .Hide();
        }
    }
}
