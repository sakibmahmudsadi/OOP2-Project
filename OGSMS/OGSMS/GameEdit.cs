using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OGSMS
{
    public partial class GameEdit : Form
    {
        public GameEdit()
        {
            InitializeComponent();
        }

        private void GameEdit_Load(object sender, EventArgs e)
        {
            this.LoadGames();
            this.ClearData();
        }
        private void ClearData()
        {
            DGV.ClearSelection();
            IdTB.Text = "Auto Generated";
            NameTB.Text = "";
            PriceTB.Text = "";
            CatagoryTB.Text = "";
            PIDTB.Text = "";
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void LoadGames()
        {
            try
            {
                //ShowGameGrid();

                var conn = new SqlConnection();
                conn.ConnectionString = Helper.cs;
                conn.Open();

                var cmnd = new SqlCommand();
                cmnd.Connection = conn;
                cmnd.CommandText = "select g.ID ID, g.NAME Name, g.PRICE Price, g.CATAGORY Catagory,g.PUBLISHER PID, u.NAME Publisher, g.PD PD from GAMES g INNER JOIN UserInfo u on g.PUBLISHER = u.ID;";

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
        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RefreshB_Click(object sender, EventArgs e)
        {
            this.LoadGames();
            this.ClearData();
        }

        private void SaveB_Click(object sender, EventArgs e)
        {
            string id = IdTB.Text;
            string name = NameTB.Text;
            string price = PriceTB.Text;
            string catagory = CatagoryTB.Text;
            //string publisher = PIDTB.Text;
            string pid= PIDTB.Text;
            string query;
            if (id == "Auto Generated")
            {
                query = $"insert into games values('{name}', '{price}', '{catagory}', '{pid}','2026-01-24');";
            }
            else { query = $"update GAMES set NAME='{name}', PRICE='{price}', CATAGORY='{catagory}', PUBLISHER='{pid}',PD='2026-01-24' WHERE ID={id};"; }
            if (name != "" && price != "" && catagory != "" && pid != "")
            {
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
                    this.LoadGames();
                    this.ClearData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Fill up all the information!");
                return;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string id = IdTB.Text;
            if (id == "Auto Generated")
            {
                MessageBox.Show("Select a Row to delete!");
                return;
            }
            var result = MessageBox.Show("Sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    var conn = new SqlConnection();
                    conn.ConnectionString = Helper.cs;
                    conn.Open();

                    var cmnd = new SqlCommand();
                    cmnd.Connection = conn;
                    cmnd.CommandText = $"delete from GAMES where id={id};";
                    cmnd.ExecuteNonQuery();
                    conn.Close();
                    this.LoadGames();
                    this.ClearData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else { return; }
        }

        private void DGV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                IdTB.Text = DGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                NameTB.Text = DGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                PriceTB.Text = DGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                CatagoryTB.Text = DGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                PIDTB.Text = DGV.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }
    }
}
