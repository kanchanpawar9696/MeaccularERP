using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Lifetime;

namespace MeaccularERP
{
   public class Cls_main
    {
        public SqlConnection con = new SqlConnection("Data Source=DESKTOP-KTEU02L\\SQLEXPRESS;Database=Demo;User Id=sa;Password=123456789");

        //public SqlConnection con = new SqlConnection("Data Source=DESKTOP-KTEU02L\\SQLEXPRESS;Database=Demo;User Id=sa;Password=123456789");

        
        public Cls_main()
        {
            if (con.State == System.Data.ConnectionState.Closed ||
                con.State == System.Data.ConnectionState.Broken)
            {
               con.Open();
                 }
           
        }
        public DataSet Read_table(string query)
        {

            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
                                                  }


    }
}
