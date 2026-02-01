using GAMEPROJECT;
using OGSMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        string id, name, type;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            SignupForm sf = new SignupForm();
            sf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPass.Text;


            if (txtEmail.Text == "")
            {
                MessageBox.Show("Please enter your email!", "Error");
                return;
            }

            if (txtPass.Text == "")
            {
                MessageBox.Show("Please enter your password!", "Error");
                return;
            }





            try
            {
                var connection = new SqlConnection();
                connection.ConnectionString = Helper.cs;
                connection.Open();

                var cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = $"select * from UserInfo where Email = '{email}' and Pass = '{password}';";

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);


                DataTable dt = ds.Tables[0];
                connection.Close();

                if(dt.Rows.Count != 1)
                {
                    MessageBox.Show("Invalid Email pr password");
                    return;
                }
                id = dt.Rows[0]["ID"].ToString();
                name = dt.Rows[0]["NAME"].ToString();
                type = dt.Rows[0]["TYPE"].ToString();
                
                //MessageBox.Show($"{name},{type}");
                //MDashBoard mdb = new MDashBoard();
                //mdb.Show();
                //this.Hide();


                if (type == "User" || type == "user")
                {
                    UserStore us = new UserStore(name,id);
                    us.Show();
                    this.Hide();
                }
                else if (type == "Publisher" || type == "publisher")
                {
                    PDashBoard pd = new PDashBoard(name,id);
                    pd.Show();
                    this.Hide();
                }
                else if (type == "Manager" || type=="manager")
                {
                    MDashBoard md = new MDashBoard(name, id);
                    md.Show();
                    this.Hide();
                }
                else if (type == "Admin" || type == "admin")
                {
                    ADashboard ad = new ADashboard(name, id); 
                    ad.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Unknown user type!", "Error");
                }






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //txtPass.UseSystemPasswordChar = true;
        private void LoginForm_Load(object sender, EventArgs e)
        {
            //txtPass.UseSystemPasswordChar = true;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            //txtPass.UseSystemPasswordChar=false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("You need to login to buy Games!","Warning");
            UserStore us = new UserStore();
            us.Show();
            this.Hide();
        }
    }
}

