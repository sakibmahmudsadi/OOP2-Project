using OGSMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace GAMEPROJECT
{
    public partial class UserStore : Form
    {
        string name="", id="";
        public UserStore() { InitializeComponent(); }
        public UserStore(string name, string id)
        {
            InitializeComponent();
            this.name = name;
            this.id = id;
            
        }
        string PID = "";

        private void button1_Click(object sender, EventArgs e)     
        {
            if (name != "" && id != "")
            {
                if (textId.Text == "" || textName.Text == "" || PID == "")
                {
                    MessageBox.Show("Please select a game first");
                    return;
                }
            }
            if(name=="" && id == "")
            {
                MessageBox.Show("You need to login to buy Games!","Warning");
                LoginForm lf=new LoginForm();
                lf.Show();
                this.Hide();
            }


            if (name != "" && id != "")
            {
                Payment pay = new Payment(
                    textId.Text,
                    textName.Text,
                    textPrice.Text, id, PID);

                pay.Show();
                this.Hide();
            }
        }




        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"{id}");
            if (name != "" && id != "")
            {

                UserLibrary pp = new UserLibrary(name, id);
                pp.Show();
                //this.Hide();
            }
            else {
                MessageBox.Show("You need to login!", "Warning");
                LoginForm lf = new LoginForm();
                lf.Show();
                this.Hide();
            }

        }

        private void UserStore_Load(object sender, EventArgs e)
        {
            this.LoadGames();
            this.ClearData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.LoadGames(); ;
            this.ClearData();

        }
        private void ClearData()
        {
            DGV.ClearSelection();
            textId.Text = "";
            textName.Text = "";
            textPrice.Text = "";
            
        }

        private void dataGridStore_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                cmnd.CommandText = "select g.ID ID, g.NAME Name, g.PRICE Price, g.CATAGORY Catagory, u.NAME Publisher, g.PUBLISHER PID, g.PD PD from GAMES g INNER JOIN UserInfo u on g.PUBLISHER = u.ID;";

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

        private void DGV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textId.Text = DGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                textName.Text = DGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                textPrice.Text = DGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                PID= DGV.Rows[e.RowIndex].Cells[6].Value.ToString();

            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

}

