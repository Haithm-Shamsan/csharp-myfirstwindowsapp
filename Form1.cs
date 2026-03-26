using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           textBox2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Hide();
            textBox1.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Show();
            textBox1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           this.Close();
           
        }
    }
}
