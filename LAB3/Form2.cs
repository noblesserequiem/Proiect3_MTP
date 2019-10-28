using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace LAB3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jucator obj = new Jucator(textBox1.Text, textBox2.Text, (Post)comboBox1.SelectedIndex);
            StreamWriter writer = new StreamWriter("D:\\LPF\\"+Form1.select_echipa+"\\"+textBox2.Text + ".lpf");
            writer.WriteLine(textBox1.Text);
            writer.WriteLine(comboBox1.SelectedItem.ToString());
            writer.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
