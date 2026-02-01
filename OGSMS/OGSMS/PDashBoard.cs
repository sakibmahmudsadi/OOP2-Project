using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OGSMS
{
    public partial class PDashBoard : Form
    {
        public PDashBoard()
        {
            InitializeComponent();
        }
        string name, id;
        public PDashBoard(string name, string id)
        {
            InitializeComponent();
            this.name = name;
            this.id = id;
        }
        private void ClearData()
        {
            DGV.ClearSelection();
            IdTB.Text = "Auto Generated";
            NameTB.Text = "";
            PriceTB.Text = "";
            CatagoryTB.Text = "";
            PIDTB.Text = id;
        }

        private void PDashBoard_Load(object sender, EventArgs e)
        {
            LoadGameData();
            this.ClearData();
            DashBoardLabel.Text = name;
        }

        private void LoadGameData()
        {
            try
            {

                var conn = new SqlConnection();
                conn.ConnectionString = Helper.cs;
                conn.Open();

                var cmnd = new SqlCommand();
                cmnd.Connection = conn;
                cmnd.CommandText = $"select * from games where publisher='{id}'";

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

        private void DeleteB_Click(object sender, EventArgs e)
        {

        }

        private void AddB_Click(object sender, EventArgs e)
        {

        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                IdTB.Text = DGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                NameTB.Text = DGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                PriceTB.Text = DGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                CatagoryTB.Text = DGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void IdTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string gid = IdTB.Text;

            if (gid == "Auto Generated")
            {
                MessageBox.Show("Select a game first!");
                return;
            }

            var result = MessageBox.Show(
                "Sure you want to delete?",
                "Confirmation",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    var conn = new SqlConnection();
                    conn.ConnectionString = Helper.cs;
                    conn.Open();

                    var cmnd = new SqlCommand();
                    cmnd.Connection = conn;
                    cmnd.CommandText =
                        $"delete from GAMES where ID={gid} and PUBLISHER='{id}';";
                    cmnd.ExecuteNonQuery();

                    conn.Close();

                    LoadGameData();
                    ClearData();
                }
                catch
                {
                    MessageBox.Show(
                        "Game cannot be deleted because it is already purchased."
                    );
                }
            }
        }

        private void NewB_Click(object sender, EventArgs e)
        {
            this.ClearData();
        }

        private void RefreshB_Click(object sender, EventArgs e)
        {
            this.LoadGameData();
            this.ClearData();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            try
            {
                var conn = new SqlConnection();
                conn.ConnectionString = Helper.cs;
                conn.Open();

                var cmnd = new SqlCommand();
                cmnd.Connection = conn;
                cmnd.CommandText = $"select SUM(PRICE) as TE from USERGAMES where PID='{id}';";

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmnd);
                adp.Fill(ds);

              


                DataTable dt = ds.Tables[0];
                label4.Text = dt.Rows[0]["TE"].ToString();


                conn.Close();
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageB_Click(object sender, EventArgs e)
        {
            string gid = IdTB.Text;
            string gname = NameTB.Text;
            string price = PriceTB.Text;
            string catagory = CatagoryTB.Text;
            string query;

            if (gname != "" && price != "" && catagory != "")
            {
                if (gid == "Auto Generated")
                {
                    query = $"insert into GAMES values('{gname}', '{price}', '{catagory}', '{id}', '2026-01-24');";
                }
                else
                {
                    query = $"update GAMES set NAME='{gname}', PRICE='{price}', CATAGORY='{catagory}' where ID={gid} and PUBLISHER='{id}';";
                }

                try
                {
                    var conn = new SqlConnection();
                    conn.ConnectionString = Helper.cs;
                    conn.Open();

                    var cmnd = new SqlCommand();
                    cmnd.Connection = conn;
                    cmnd.CommandText = query;
                    cmnd.ExecuteNonQuery();

                    conn.Close();

                    LoadGameData();
                    ClearData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Fill up all the information!");
            }
        }

        
    }

}
        
    
