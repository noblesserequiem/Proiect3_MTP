using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            String user, pass;
            user = textBox1.Text;
            pass = textBox2.Text;
            progressBar1.Maximum = 1000;
            progressBar1.Step = 1;
            if (user == "Admin" && pass == "Admin")
            {
                
                for (int i = 0; i <= 1000; i++)
                {
                    progressBar1.PerformStep();
                }
                MessageBox.Show("Success");
                Close();
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }
    }
}
