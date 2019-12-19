/*
 * Author: Bilal Ahmad
 * Date: December 07, 2019
 * Purpose: Welcome screen with a button which shows up first.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilalAhmad_CPRG200_Lab2
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        // when Click to Begin button is clicked
        private void btnBegin_Click(object sender, EventArgs e)
        {
            // new customer bill is initialized
            CustomerBill customerBill = new CustomerBill();
            customerBill.StartPosition = FormStartPosition.Manual;// set the start position to manual rather than set by the system
            customerBill.Location = this.Location; // set the location of the customerbill to the same location as the welcome screen
            

            customerBill.Show(); // show the customerbill form

            this.Visible = false; // hide the welcome screen

            
        }
    }
}
