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
    public partial class PublisherEdit : Form
    {
        public PublisherEdit()
        {
            InitializeComponent();
        }

        private void PublisherEdit_Load(object sender, EventArgs e)
        {
            try
            {

                var conn = new SqlConnection();
                conn.ConnectionString = Helper.cs;
                conn.Open();

                var cmnd = new SqlCommand();
                cmnd.Connection = conn;
                cmnd.CommandText = "select * from UserInfo where Type = 'Publisher'";


                //DGV.Columns[0].DataPropertyName = "ID";
                //DGV.Columns[1].DataPropertyName = "NAME";
                //DGV.Columns[2].DataPropertyName = "EMAIL";
                //DGV.Columns[3].DataPropertyName = "PASS";
                //DGV.Columns[4].DataPropertyName = "TYPE";



                DataSet ds = new DataSet();
                var sda = new SqlDataAdapter(cmnd);
                sda.Fill(ds);

                DataTable dt = ds.Tables[0];

                DGV.AutoGenerateColumns = false;
                DGV.DataSource = dt;
                DGV.Refresh();
                DGV.ClearSelection();

                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadData()
        {
            try
            {

                var conn = new SqlConnection();
                conn.ConnectionString = Helper.cs;
                conn.Open();

                var cmnd = new SqlCommand();
                cmnd.Connection = conn;
                cmnd.CommandText = "select * from UserInfo where Type = 'Publisher'";


                //DGV.Columns[0].DataPropertyName = "ID";
                //DGV.Columns[1].DataPropertyName = "NAME";
                //DGV.Columns[2].DataPropertyName = "EMAIL";
                //DGV.Columns[3].DataPropertyName = "PASS";
                //DGV.Columns[4].DataPropertyName = "TYPE";



                DataSet ds = new DataSet();
                var sda = new SqlDataAdapter(cmnd);
                sda.Fill(ds);

                DataTable dt = ds.Tables[0];

                DGV.AutoGenerateColumns = false;
                DGV.DataSource = dt;
                DGV.Refresh();

                DGV.ClearSelection();

                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RefreshB_Click(object sender, EventArgs e)
        {
            this.LoadData();
            this.NewData();

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string id = IdTB.Text;

            if (id == "Auto Generated")
            {
                MessageBox.Show("Please select a row first");
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
                    cmnd.CommandText = $"delete from UserInfo where ID={id};";
                    cmnd.ExecuteNonQuery();

                    conn.Close();

                    this.LoadData();
                    this.NewData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
        "This publisher cannot be deleted because games are already assigned to them."
    );
                }
            }
        }
    
            

        private void NewB_Click(object sender, EventArgs e)
        {
            this.NewData();
        }


        private void NewData()
        {
            DGV.ClearSelection();
            IdTB.Text = "Auto Generated";
            NameTB.Text = "";
            EmailTB.Text = "";
            PassTB.Text = "";
            TypeTB.Text = "Publisher";

        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SaveB_Click(object sender, EventArgs e)
        {
            string id = IdTB.Text;
            string name = NameTB.Text;
            string email = EmailTB.Text;
            string pass = PassTB.Text;
            string type = "Publisher";
            string query;

            if (name != "" && email != "" && pass != "")
            {
                if (id == "Auto Generated")
                {
                    query = $"insert into UserInfo values('{name}', '{email}', '{pass}', 'Publisher');";

                }
                else
                {
                    query = $"update UserInfo set NAME='{name}', EMAIL='{email}', PASS='{pass}', TYPE='Publisher' where ID={id};";

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

                    this.LoadData();
                    this.NewData();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PassTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void TypeTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void IdTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void IdLabel_Click(object sender, EventArgs e)
        {

        }

        private void TypeLabel_Click(object sender, EventArgs e)
        {

        }

        private void PeiceLabel_Click(object sender, EventArgs e)
        {

        }

        private void NamwLabel_Click(object sender, EventArgs e)
        {

        }

        private void Id_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                IdTB.Text = DGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                NameTB.Text = DGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                EmailTB.Text = DGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                PassTB.Text = DGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                TypeTB.Text = DGV.Rows[e.RowIndex].Cells[4].Value.ToString();
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
