using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OGSMS
{
    public partial class ADashboard : Form
    {
        string name, id;

        string seletecedUserType = "Manager";
        
        public ADashboard(string name, string id)
        {
            this.name = name;
            this.id = id;
            InitializeComponent();

        }


        private void DashBoardLabel_Click(object sender, EventArgs e)
        {
            DashBoardLabel.Text= name;
        }

        private void DashBoardPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ManageB_Click(object sender, EventArgs e)
        {
            if (seletecedUserType == "Manager"){
                ManagerEdit ms = new ManagerEdit();
                ms.Show();
                //this.Hide();
            }else if (seletecedUserType == "User")
            {
                UserEdit us = new UserEdit();
                us.Show();
                //this.Hide();
            }else if(seletecedUserType == "Publisher")
            {
                PublisherEdit ps = new PublisherEdit();
                ps.Show();
                //this.Hide();
            }
            else { GameEdit ge=new GameEdit();
            ge.Show();}
            
        }

        private void MDashboard_Load(object sender, EventArgs e)
        {
            this.LoadManagerData();
            DashBoardLabel.Text = name;
        }
        private void LoadManagerData()
        {
            try
            {
                ShowUserGrid();

                var conn = new SqlConnection();
                conn.ConnectionString = Helper.cs;
                conn.Open();

                var cmnd = new SqlCommand();
                cmnd.Connection = conn;
                cmnd.CommandText = "select * from UserInfo where type='Manager';";

                DataSet ds = new DataSet();
                var sda = new SqlDataAdapter(cmnd);
                sda.Fill(ds);
                DataTable dt = ds.Tables[0];
                DGV.AutoGenerateColumns = false;
                DGV.DataSource = dt;
                DGV.Refresh();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadPublisherData()
        {
            try
            {
                ShowUserGrid();

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

                DGV.AutoGenerateColumns = false;
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

                ShowUserGrid();

                var conn = new SqlConnection();
                conn.ConnectionString = Helper.cs;
                conn.Open();

                var cmnd = new SqlCommand();
                cmnd.Connection = conn;
                cmnd.CommandText = "select * from UserInfo where type='User';";

                DataSet ds = new DataSet();
                var sda = new SqlDataAdapter(cmnd);
                sda.Fill(ds);
                DataTable dt = ds.Tables[0];

                DGV.AutoGenerateColumns = false;
                DGV.DataSource = dt;
                DGV.Refresh();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PublisherB_Click(object sender, EventArgs e)
        {
            seletecedUserType = "Publisher";
            this.LoadPublisherData();
        }

        private void ManagerB_Click(object sender, EventArgs e)
        {
            seletecedUserType = "Manager";
            this.LoadManagerData();
        }

        private void CustomerB_Click(object sender, EventArgs e)
        {
            seletecedUserType = "User";
            this.LoadUserData();
        }

        
        private void LoadGames()
        {
            try
            {
                ShowGameGrid();

                var conn = new SqlConnection();
                conn.ConnectionString = Helper.cs;
                conn.Open();

                var cmnd = new SqlCommand();
                cmnd.Connection = conn;
                cmnd.CommandText = "select g.ID ID, g.NAME Name, g.PRICE Price, g.CATAGORY Catagory, u.NAME Publisher, g.PD PD from GAMES g INNER JOIN UserInfo u on g.PUBLISHER = u.ID;";

                DataSet ds = new DataSet();
                var sda = new SqlDataAdapter(cmnd);
                sda.Fill(ds);
                DataTable dt = ds.Tables[0];
                DGV.AutoGenerateColumns = false;
                DGV2.DataSource = dt;
                DGV2.Refresh();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GamesB_Click(object sender, EventArgs e)
        {
            this.LoadGames();
            seletecedUserType = "Games";
        }
        private void ShowUserGrid()
        {
            DGV.Visible = true;
            DGV2.Visible = false;
        }
        private void ShowGameGrid()
        {
            DGV.Visible = false;
            DGV2.Visible = true;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Click(object sender, EventArgs e)
        {
            AdminEdit ae= new AdminEdit();
            ae.Show();
        }

        private void DGV2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
