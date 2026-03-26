using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MyFirstWindowsApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi this is my first Massage");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi this is my first Massage","this is message");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Hi this is my first Massage", "this is message",MessageBoxButtons.OKCancel)==DialogResult.Cancel)
            {
                MessageBox.Show("Are you sure you want to cansle?","this is message", MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
            }
        }

        private void ChkBox_CheckedChanged(object sender, EventArgs e)
        {
           
           button2.Enabled = ChkBox.Checked;
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sen , EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(radioButton1.Checked.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form3 = new Form4();
           form3. ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f = new Form5();
            f.ShowDialog();
        }
    }
}
