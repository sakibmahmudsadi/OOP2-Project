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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SignupForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void SignupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string type  = "";

            string name = txtName.Text;
            string email = txtEmail.Text;
            string password = txtPass.Text;
            string cpass = txtCPass.Text;

            if (rbtnPublisher.Checked)
            {
                type = "Publisher";
            }
            else if (rbtnUser.Checked)
            {
                type = "User";
            }
            if(type == "")
            {
                MessageBox.Show("Invalid Register", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (name == "")
            {
                MessageBox.Show("Please enter your name!", "Error");
                return;
            }


            if (email == "" )
            {
                MessageBox.Show("Please enter your email!", "Error");
                return;
            }

            if(email.Contains("@") == false || email.Contains(".com") == false)
            {
                MessageBox.Show("Please enter proper properties(@,.com)");
                return;
            }

            if (password == "")
            {
                MessageBox.Show("Please enter your password!", "Error");
                return;
            }

            if (cpass == "")
            {
                MessageBox.Show("Please enter your Confarmation password!", "Error");
                return;
            }

            //if (password != cpass)
            //{
            //    MessageBox.Show("Password and Confirm Password do not match!", "Error");
            //    return;
            //}


            if (!checkterm.Checked)
            {
                MessageBox.Show("Please agree with condition!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                    var con = new SqlConnection();
                    con.ConnectionString = Helper.cs;
                    con.Open();
                    

                    var cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = $"insert into UserInfo values('{name}','{email}','{password}','{type}')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Signup Succesful");
                LoginForm lf=new LoginForm();
                lf.Show();
                this.Hide();
                

                }
                catch(Exception ex)
                {
                MessageBox.Show(ex.Message); 
                }
        }

        private void Register_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Transparent;
        }
        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
        }

        private void button2_MouseLeave_1(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }

        private void button2_MouseHover_1(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }

        private void rbtnPublisher_Click(object sender, EventArgs e)
        {
            //rbtnPublisher.BackColor = Color.Red;
        }

        private void rbtnUser_Click(object sender, EventArgs e)
        {
            //rbtnUser.BackColor = Color.Red;
        }
    }
}
