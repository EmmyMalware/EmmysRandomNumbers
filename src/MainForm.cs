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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            selectComboBox.Items.Add("Landline phone");
            selectComboBox.Items.Add("Cell phone");
            selectComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genTextBox.ReadOnly = true;
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            string copyNumber = genTextBox.Text;
            if (genTextBox.Text == "(909)-XXX-XXXX")
            {
                MessageBox.Show("You did not generate a number. Click \"Generate Number!\" to generate a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!string.IsNullOrEmpty(copyNumber))
            {
                Clipboard.SetText(copyNumber);
                MessageBox.Show("Number copied to clipboard!", "Copied", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void genButton_Click(object sender, EventArgs e)
        {
            Random RNG = new Random();

            int prefix = RNG.Next(100, 1000);     // ensures first digit isn't 0
            int lineNumber = RNG.Next(0, 10000);  // can be 0000 to 9999
            string phoneNumber = "(909)-" + prefix + "-" + lineNumber;

            genTextBox.Text = phoneNumber;
        }

        private void star67Button_Click(object sender, EventArgs e)
        {
            int cursorPosition = genTextBox.SelectionStart;

            if (!genTextBox.Text.StartsWith("*67"))
            {
                genTextBox.Text = "*67" + genTextBox.Text;
                genTextBox.SelectionStart = cursorPosition + 4; 
            }
        }

        private void manPhoneGenButton_Click(object sender, EventArgs e)
        {
            new ManPhoneGenForm().ShowDialog();
        }
    }
}
