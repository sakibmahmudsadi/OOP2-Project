using OGSMS;
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
using System.Web;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace GAMEPROJECT
{
    public partial class PayCard : Form
    {
        string gameId, gameName, gamePrice, pid, uid;

        public PayCard(string id, string name, string price, string UID, string PID)
        {
            InitializeComponent();
            gameId = id;
            gameName = name;
            gamePrice = price;
            uid = UID;
            pid = PID;
            lblAmount.Text = "$" + gamePrice;
        }
        public PayCard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCardHolder_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonPay_Click(object sender, EventArgs e)
        { 

            string cardNumber = textCardNo.Text;
            string cardHolder = textCardHolder.Text;
            string expiryDate = textBox1.Text;
            string cvc = textCvc.Text;

            if (cardNumber == "")
            {
                MessageBox.Show("Invalid Card Number", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textCardNo.Focus();
                return;
            }

            if (cardNumber.Length != 16)
            {
                MessageBox.Show("Card Number must be 16 digits", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textCardNo.Focus();
                return;
            }

            if (cardHolder == "")
            {
                MessageBox.Show("Invalid Card Holder Name", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textCardHolder.Focus();
                return;
            }

            if (expiryDate == "")
            {
                MessageBox.Show("Invalid Expiry Date", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }

            if (cvc == "")
            {
                MessageBox.Show("Invalid CVC", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textCvc.Focus();
                return;
            }

            //if (cvc.Length != 3 || cvc.Length != 4)
            //{
            //    MessageBox.Show("CVC must be 3 o digits", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    textCvc.Focus();
            //    return;
            //}
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
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void PayCard_Load(object sender, EventArgs e)
        {

        }

        private void lblAmount_Click(object sender, EventArgs e)
        {
            label1.Text = gamePrice;
        }

        private void textCvc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



