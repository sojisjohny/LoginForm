using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginExperiment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((textBox1.Text == "") || (textBox2.Text == ""))
            {
                MessageBox.Show("enter username and password", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
               // textBox3.Text = "enter username and password";
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else 
            {
                MessageBox.Show("Logged in to your account successfully", "Message", MessageBoxButtons.OK);
              
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

       
    }
}
