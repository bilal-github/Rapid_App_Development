using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilalAhmad_CPRG200_Lab1
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {           
            CustomerBill customerBill = new CustomerBill();
            customerBill.Show();
            Visible = false;

            
        }
    }
}
