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
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GAMEPROJECT
{
    public partial class UserLibrary : Form
    {
        string name, id;
        //public UserLibrary() { }
        public UserLibrary(string name,string id)
        {
            InitializeComponent();
            this.name = name;
            this.id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserStore pp = new UserStore(name, id);
            pp.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UserStore pp = new UserStore(name,id);
            pp.Show();
            this.Hide();
        }

        private void UserLibrary_Load(object sender, EventArgs e)
        {
            LoadGames();
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
                cmnd.CommandText = $"SELECT G.ID ID, G.NAME Name, G.PRICE Price, G.CATAGORY Catagory, U.NAME Publisher, G.PD PD FROM USERGAMES UG INNER JOIN GAMES G ON UG.GID = G.ID INNER JOIN UserInfo U ON G.PUBLISHER = U.ID WHERE UG.UID = {id};";

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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
