using System;
using System.Collections;
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
    public partial class ManagerEdit : Form
    {
        public ManagerEdit()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RefreshB_Click(object sender, EventArgs e)
        {
            this.LoadManagerData();
            this.ClearData();
        }

        private void NewB_Click(object sender, EventArgs e)
        {
            this.ClearData();
        }

        private void ClearData()
        {
            DGV.ClearSelection();
            IdTB.Text = "Auto Generated";
            NameTB.Text = "";
            EmailTB.Text = "";
            PassTB.Text = "";
            TypeTB.Text = "";
            TypeTB.Text = "Manager";
            
        }

        private void LoadManagerData()
        {
            try
            {

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

        private void Editing_Load(object sender, EventArgs e)
        {
            this.LoadManagerData();
            this.ClearData();

        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                IdTB.Text = DGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                NameTB.Text= DGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                EmailTB.Text= DGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                PassTB.Text= DGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                TypeTB.Text= DGV.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string id=IdTB.Text;
            if(id == "Auto Generated")
            {
                MessageBox.Show("Select a Row to delete!");
                return;
            }
            var result=MessageBox.Show("Sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes) 
            {
                try {
                    var conn = new SqlConnection();
                    conn.ConnectionString = Helper.cs;
                    conn.Open();

                    var cmnd = new SqlCommand();
                    cmnd.Connection = conn;
                    cmnd.CommandText = $"delete from UserInfo where id={id};";
                    cmnd.ExecuteNonQuery();
                    conn.Close();
                    this.LoadManagerData();
                    this.ClearData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else { return; }
        }

        private void SaveB_Click(object sender, EventArgs e)
        {
            string id = IdTB.Text;
            string name = NameTB.Text;
            string email = EmailTB.Text;
            string pass = PassTB.Text;
            string type = TypeTB.Text;
            string query;
            if (id == "Auto Generated")
            {
                query= $"insert into UserInfo values('{name}', '{email}', '{pass}', '{type}');";
            }
            else { query=$"update UserInfo set NAME='{name}', EMAIL='{email}', PASS='{pass}', TYPE='{type}' WHERE ID={id};"; }
            if(name != "" && email != "" && pass != "" && type != "")
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
                    this.LoadManagerData();
                    this.ClearData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else {
                MessageBox.Show("Fill up all the information!");
                return; 
            }
        }

        private void TypeLabel_Click(object sender, EventArgs e)
        {

        }

        private void BB_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BB_MouseHover(object sender, EventArgs e)
        {
            BB.BackColor = Color.Red;
        }

        private void BB_MouseLeave(object sender, EventArgs e)
        {
            BB.BackColor = Color.Transparent;
        }
    }
}
