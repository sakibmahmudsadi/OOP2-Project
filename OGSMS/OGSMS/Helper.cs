using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OGSMS
{
    internal class Helper
    {
        public static string cs = "Data Source=(Add your pc name without brackets);Initial Catalog=OGSMS;Integrated Security=True;Encrypt=False";
        //public static void LoadManagerData(){
        //    try
        //    {

        //        var conn = new SqlConnection();
        //        conn.ConnectionString = Helper.cs;
        //        conn.Open();

        //        var cmnd = new SqlCommand();
        //        cmnd.Connection = conn;
        //        cmnd.CommandText = "select * from UserInfo where type='Manager';";

        //        DataSet ds = new DataSet();
        //        var sda = new SqlDataAdapter(cmnd);
        //        sda.Fill(ds);
        //        DataTable dt = ds.Tables[0];

        //        DGV.AutoGenerateColumns = false;
        //        DGV.DataSource = dt;
        //        DGV.Refresh();

        //        conn.Close();
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Error!Try Again");
        //    }
        //}
        
    }

}
