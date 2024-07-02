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
    public partial class frm_login : Form
    {

        Cls_main obj = new Cls_main();

        public frm_login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            DataSet ds=obj.Read_table ("Select * from Login where UserName='" + txt_useid.Text + "' and Password='"+ txt_password .Text +"'");

            if (ds.Tables[0].Rows.Count > 0)

            {
                frm_customerinformation obj = new frm_customerinformation();
                obj.Show();
            }
            else
            {

                MessageBox.Show("Invalid UserName  and Password","Message");
                txt_useid.Select();
                                             
            }
            txt_useid.Clear();
            txt_password.Clear();



        }

        private void btn_forgetpwd_Click(object sender, EventArgs e)
        {
            frm_forgetpassword obj = new frm_forgetpassword();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_password.Clear();
            txt_useid.Clear();
        }

        private void txt_useid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_password.Focus();
            }

        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2.Focus();
            }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            txt_useid.Select ();
        }
    }
}
