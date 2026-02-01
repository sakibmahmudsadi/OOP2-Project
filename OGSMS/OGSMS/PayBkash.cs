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
using WindowsFormsApp1;

namespace GAMEPROJECT
{
    public partial class PayBkash : Form
    {
        
        string gameId, gameName, gamePrice, uid, pid;

      
        public PayBkash(string id, string name, string price, string UID, string PID)
        {
            InitializeComponent();
            gameId = id;
            gameName = name;
            gamePrice = price;
            uid=UID; 
            pid = PID;
            lblAmount.Text = "BDT" + gamePrice; 
        }
        

        
        public PayBkash()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PayBkash_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string bkashNumber = txtBkashNumber.Text;
            string bkashPin = txtBkashPin.Text;

            if (bkashNumber == "")
            {
                MessageBox.Show("bKash account number empty!", "Error");
                return;
            }

            if (bkashNumber.Length != 11 || !bkashNumber.All(char.IsDigit))
            {
                MessageBox.Show("bKash number must be 11 digits", "Error");
                return;
            }

            if (bkashPin == "")
            {
                MessageBox.Show("bKash PIN empty!", "Error");
                return;
            }

            if (bkashPin.Length != 5 )
            {
                MessageBox.Show("bKash PIN must be 5 digits", "Error");
                return;
            }
            string query = $"INSERT INTO USERGAMES Values({uid}, {gameId}, {pid}, {gamePrice})";
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Payment Successful\nAmount: " + lblAmount.Text,
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoginForm lf=new LoginForm();
            lf.Show();
            this.Hide();

            
        }

        private void txtBkashNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


