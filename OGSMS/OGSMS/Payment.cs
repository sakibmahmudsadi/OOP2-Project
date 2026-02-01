using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;



namespace GAMEPROJECT
{
    public partial class Payment : Form
    {
        string pid,uid;
        public Payment(string id, string name, string price, string UID, string PID)
        {
            InitializeComponent();

            textId.Text = id;
            textName.Text = name;
            textPrice.Text = price;
            pid = PID;
            uid = UID;

            
            textId.ReadOnly = true;
            textName.ReadOnly = true;
            textPrice.ReadOnly = true;
        }

        
        public Payment()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            UserStore pp = new UserStore(textName.Text, textId.Text);
            pp.Show();
            this.Hide();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            LoginForm lf=new LoginForm();
            lf.Show();
            this.Hide();


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioBkash.Checked)
            {
                PayBkash pb =new PayBkash(textId.Text, textName.Text, textPrice.Text, uid, pid);
                pb.Show();
                this.Hide();
            }
            else if (radioCard.Checked)
            {
                PayCard pc= new PayCard(textId.Text, textName.Text, textPrice.Text, uid, pid);
                pc.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Select a payment method");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


