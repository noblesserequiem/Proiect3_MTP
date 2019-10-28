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
    public partial class Form1 : Form
    {
        public static String  select_echipa;
        public Form1()
        {
            InitializeComponent();
            Directory.CreateDirectory("D:\\LPF");
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nume = comboBox1.Text;
            Directory.CreateDirectory("D:\\LPF\\" + nume);
            comboBox1.Items.Add(nume);
        }
        private void ActualizareComboBox(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
           
            foreach (String dir in Directory.EnumerateDirectories("D:\\LPF"))
            {
                comboBox1.Items.Add(new DirectoryInfo(dir).Name);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            select_echipa = comboBox1.SelectedItem.ToString();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void AfisareJucatori(object sender, EventArgs e)
        {
            
            foreach (String path in Directory.EnumerateFiles("D:\\LPF\\" + comboBox1.SelectedItem.ToString(), "*.lpf"))
            {
                StreamReader reader = new StreamReader(path);
                String nume_juc = reader.ReadLine();
                Button btn = new Button();
                btn.Text = nume_juc;
                btn.Width = 200;
                
                flowLayoutPanel1.Controls.Add(btn);
                btn.Click += Btn_Click;

            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Jucator j = (Jucator)btn.Tag;
        }
    }
}
