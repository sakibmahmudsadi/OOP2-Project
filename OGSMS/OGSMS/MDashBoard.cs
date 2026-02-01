using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace OGSMS
{
    public partial class MDashBoard : Form
    {
        string name, id;
        string seletecedUserType = "Publisher";

        public MDashBoard(string name, string id)
        {
            InitializeComponent();
            this.name = name;
            this.id = id;
        }

        private void MDashBoard_Load(object sender, EventArgs e)
        {
            this.LoadPublisherData();
            DashBoardLabel.Text = name;

        }

       

        private void PublisherB_Click(object sender, EventArgs e)
        {
            seletecedUserType = "Publisher";
            this.LoadPublisherData();

        }

        private void CustomerB_Click(object sender, EventArgs e)
        {
            seletecedUserType = "User";
            this.LoadUserData();
        }

        private void GamesB_Click(object sender, EventArgs e)
        {
            this.LoadGames();
            seletecedUserType = "Games";
        }

        
        private void LoadPublisherData()
        {
            try
            {
                

                var conn = new SqlConnection();
                conn.ConnectionString = Helper.cs;
                conn.Open();

                var cmnd = new SqlCommand();
                cmnd.Connection = conn;
                cmnd.CommandText = "select * from UserInfo where type='publisher';";

                DataSet ds = new DataSet();
                var sda = new SqlDataAdapter(cmnd);
                sda.Fill(ds);
                DataTable dt = ds.Tables[0];

                DGV.AutoGenerateColumns = true;
                DGV.DataSource = dt;
                DGV.Refresh();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void LoadUserData()
        {
            try
            {
               

                var conn = new SqlConnection();
                conn.ConnectionString = Helper.cs;
                conn.Open();

                var cmnd = new SqlCommand();
                cmnd.Connection = conn;
                cmnd.CommandText = "select * from UserInfo where type='user';";

                DataSet ds = new DataSet();
                var sda = new SqlDataAdapter(cmnd);
                sda.Fill(ds);
                DataTable dt = ds.Tables[0];

                DGV.AutoGenerateColumns = true;
                DGV.DataSource = dt;
                DGV.Refresh();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ManageB_Click(object sender, EventArgs e)
        {
            if (seletecedUserType == "User")
            {
                UserEdit us = new UserEdit();
                us.Show();
                //this.Hide();
            }
            else if (seletecedUserType == "Publisher")
            {
                PublisherEdit ps = new PublisherEdit();
                ps.Show();
                //this.Hide();
            }
            else
            {
                GameEdit ge = new GameEdit();
                ge.Show();
            }
        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadGames()
        {
            try
            {
               

                var conn = new SqlConnection();
                conn.ConnectionString = Helper.cs;
                conn.Open();

                var cmnd = new SqlCommand();
                cmnd.Connection = conn;
                cmnd.CommandText =
                    "select g.ID, g.NAME, g.PRICE, g.CATAGORY, " +
                    "u.NAME as Publisher, g.PD " +
                    "from GAMES g inner join UserInfo u on g.PUBLISHER = u.ID;";

                DataSet ds = new DataSet();
                var sda = new SqlDataAdapter(cmnd);
                sda.Fill(ds);
                DataTable dt = ds.Tables[0];

                DGV.AutoGenerateColumns = true;
                DGV.DataSource = dt;
                DGV.Refresh();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

