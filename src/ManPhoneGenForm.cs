using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmmysRandomNumbers
{
    public partial class ManPhoneGenForm : Form
    {
        public ManPhoneGenForm()
        {
            InitializeComponent();
        }

        private void ManPhoneGenForm_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox1.Text = "(909)";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string copyNumber = textBox1.Text;
            if (!string.IsNullOrEmpty(copyNumber))
            {
                Clipboard.SetText(copyNumber);
                MessageBox.Show("Number copied to clipboard!", "Copied", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "#";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int cursorPosition = textBox1.SelectionStart;

            if (!textBox1.Text.StartsWith("*67"))
            {
                textBox1.Text = "*67" + textBox1.Text;
                textBox1.SelectionStart = cursorPosition + 4; 
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Haha just kidding you can't call a number using modem on this program", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
