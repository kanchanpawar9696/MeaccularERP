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
    public partial class frm_customerinformation : Form
    {

        Cls_main obj = new Cls_main();
        public frm_customerinformation()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           
            {



                if (txt_custname.Text == "")
                {
                    MessageBox.Show("Please Enter the Customer Name", "messege", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_address.Focus();
                    return;


                }



                SqlCommand cmd = new SqlCommand("Insert into Customer_Information(Cust_Id ,Cust_Name ,Address ,District ,Taluka ,City ,State ,Pin_Code ,Mobile_No ,Email ,Birth_Date ,Aadhar_No)values(@Cust_Id ,@Cust_Name ,@Address ,@District ,@Taluka ,@City ,@State ,@Pin_Code ,@Mobile_No ,@Email ,@Birth_Date ,@Aadhar_No)", obj.con);
                cmd.Parameters.AddWithValue("@Cust_Id", txt_custcode.Text);
                cmd.Parameters.AddWithValue("@Cust_Name", txt_custname.Text);
                cmd.Parameters.AddWithValue("@Address", txt_address.Text);
                cmd.Parameters.AddWithValue("@District", cmb_district.Text);
                cmd.Parameters.AddWithValue("@Taluka", cmb_taluka.Text);
                cmd.Parameters.AddWithValue("@City", cmb_city.Text);
                cmd.Parameters.AddWithValue("@State", txt_state.Text);
                cmd.Parameters.AddWithValue("@Pin_Code", txt_pin.Text);
                cmd.Parameters.AddWithValue("@Mobile_No", txt_mobileno.Text);
                cmd.Parameters.AddWithValue("@Email", txt_email.Text);
                cmd.Parameters.AddWithValue("@Birth_Date", dtp_birthdate.Text);
                cmd.Parameters.AddWithValue("@Aadhar_No", txt_AadhaarNo.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Saved Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_custcode.Clear();
                txt_custname.Clear();
                txt_address.Clear();
                txt_pin.Clear();
                txt_mobileno.Clear();
                txt_AadhaarNo.Clear();
                txt_email.Clear();
                txt_state.ResetText();
                cmb_taluka.ResetText();
                cmb_city.ResetText();
                cmb_taluka.ResetText();
                dtp_birthdate.ResetText();

            }
          
           
        }

      

        private void txt_custname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                {
                 txt_address.Focus();
            }
        }

        private void txt_address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_district.Focus();
            }
        }

        private void cmb_district_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_taluka.Focus();
            }
        }

        private void cmb_taluka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_city.Focus();
            }
        }

        private void cmb_city_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_state.Focus();
            }
        }

        private void txt_state_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_pin.Focus();

             

              
            }

        }

        private void txt_pin_KeyDown(object sender, KeyEventArgs e)
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
                txt_email.Focus();
            }
        }

        private void txt_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtp_birthdate .Focus();
            }
        }

        private void dtp_birthdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_AadhaarNo.Focus();
            }
        }

        private void txt_AadhaarNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_save.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("UPDATE Customer_Information SET Cust_Name=@Cust_Name ,Address=@Address ,District=@District ,Taluka=@Taluka ,City=@City ,State=State ,Pin_Code=@Pin_Code ,Mobile_No=@Mobile_No ,Email=@Email ,Birth_Date=@Birth_Date ,Aadhar_No=@Aadhar_No  where Cust_Id= '" + txt_custcode.Text + "'", obj.con);
            
            cmd.Parameters.AddWithValue("@Cust_Name", txt_custname.Text);
            cmd.Parameters.AddWithValue("@Address", txt_address.Text);
            cmd.Parameters.AddWithValue("@District", cmb_district.Text);
            cmd.Parameters.AddWithValue("@Taluka", cmb_taluka.Text);
            cmd.Parameters.AddWithValue("@City", cmb_city.Text);
            cmd.Parameters.AddWithValue("@State", txt_state.Text);
            cmd.Parameters.AddWithValue("@Pin_Code", txt_pin.Text);
            cmd.Parameters.AddWithValue("@Mobile_No", txt_mobileno.Text);
            cmd.Parameters.AddWithValue("@Email", txt_email.Text);
            cmd.Parameters.AddWithValue("@Birth_Date", dtp_birthdate.Text);
            cmd.Parameters.AddWithValue("@Aadhar_No", txt_AadhaarNo.Text);
            cmd.ExecuteNonQuery();


            MessageBox.Show("customer Updated successfylly");
        }

        int max = 0;

        private void frm_customerinformation_Load(object sender, EventArgs e)
        {
           
           
        }

        private void txt_custname_TextChanged(object sender, EventArgs e)
        {
            if(txt_custname.Text !="")
            {
                DataSet ds = obj.Read_table("select * from Customer_Information");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    lst_custname.BringToFront();
                    lst_custname.Visible = true;
                    lst_custname.Items.Clear();


                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        lst_custname.Items.Add(ds.Tables[0].Rows[i]["Cust_Id"] + "-" + ds.Tables[0].Rows[i]["Cust_Name"] + "-" + ds.Tables[0].Rows[i]["Address"] + "-" + ds.Tables[0].Rows[i]["District"] + "-" + ds.Tables[0].Rows[i]["Taluka"] + "-" + ds.Tables[0].Rows[i]["City"] + "-" + ds.Tables[0].Rows[i]["State"] + "-" + ds.Tables[0].Rows[i]["Pin_Code"] + "-" + ds.Tables[0].Rows[i]["Mobile_No"] + "-" + ds.Tables[0].Rows[i]["Email"] + "-" + ds.Tables[0].Rows[i]["Birth_Date"] + "-" + ds.Tables[0].Rows[i]["Aadhar_No"]);

                    }

                }
            }
        }
    }
}
