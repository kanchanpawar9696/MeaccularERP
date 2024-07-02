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
    public partial class frm_userinformation : Form
    {


        Cls_main obj = new Cls_main();
        public frm_userinformation()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert into Login(UserName ,Password ,Mobile_No) values(@UserName ,@Password ,@Mobile_No)", obj.con);
            cmd.Parameters.AddWithValue("@UserName", txt_username.Text);
            cmd.Parameters.AddWithValue("@Password", txt_pwd.Text);
            cmd.Parameters.AddWithValue("@Mobile_No", txt_mobileno.Text);
            cmd.ExecuteNonQuery();

            MessageBox.Show("UserName Save Successfully", "Meassage",MessageBoxButtons.YesNo );
            txt_username.Clear();
            txt_pwd.Clear();
            txt_mobileno.Clear();
                               }

        private void txt_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_pwd.Focus();
                                                         }
        }

        private void txt_pwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_mobileno.Focus();
            }
        }

        private void txt_mobileno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_save.Focus();
            }

            if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_pwd.Clear();
            txt_mobileno.Clear();
        }

        private void frm_userinformation_Load(object sender, EventArgs e)
        {
            txt_username.Select();
        }

        private void txt_mobileno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')|| (e.KeyChar == (char)Keys.Back))
                
            {
                e.Handled = true;
            }

        }

        private void txt_username_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }
    }
}
