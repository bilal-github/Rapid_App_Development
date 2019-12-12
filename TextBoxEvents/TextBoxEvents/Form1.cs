using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        //fires after test box loses focus
        private void txtPostalCode_Validating(object sender, CancelEventArgs e)
        {
            // use regular expression
            Regex pattern = new Regex("^([a-zA-Z][0-9]){3}$"); //repeat 3 times{3}
            if (txtPostalCode.Text == "")
            {
                MessageBox.Show("Please enter postal code");
            }
            else if (!pattern.IsMatch(txtPostalCode.Text)) // if doesn't match
            {
                MessageBox.Show("Postal Code needs to be in format X1X1X1");
                txtPostalCode.SelectAll();
                txtPostalCode.Focus();
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  e.KeyChar contains the character that was pressed
            // e.Handled is a boolean that indicates that handling is done
            //if a bad character is entered, set e.Handled to true
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-' &&
                e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
