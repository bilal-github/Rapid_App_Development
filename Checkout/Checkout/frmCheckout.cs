using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkout
{
    public partial class frmCheckout : Form
    {   // form-level variables

        const decimal TAX_PCT = 0.05m;  //m for money
        public frmCheckout()
        {
            InitializeComponent();
        }

        //calculate checkout amount based on price and quantity
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //local variables
            int qty; // quantity purchase
            decimal price; // unit price
            decimal subTotal; //before tax
            decimal taxAmount; //added tax
            decimal payAmount; // money at checkout (to calculate)
            if (Validator.IsPresent(txtPrice, "Price") && Validator.IsNonNegativeDecimal(txtPrice, "Price") &&
                Validator.IsPresent(txtQuantity, "Quantity") && Validator.IsNonNegativeInt32(txtQuantity, "Quantity"))
            {
                //get qty and price
                qty = Convert.ToInt32(txtQuantity.Text);
                price = Convert.ToDecimal(txtPrice.Text);

                // calculate pay amount
                subTotal = qty * price;
                taxAmount = subTotal * TAX_PCT;

                payAmount = subTotal + taxAmount;

                //display result
                lblSubtotal.Text = subTotal.ToString("c");
                lblTax.Text = taxAmount.ToString("c");
                lblPayAmount.Text = payAmount.ToString("c");
                //lblPayAmount.Text = Convert.ToString(payAmount);
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPrice.Text = "";
            txtQuantity.Text = "";
            lblSubtotal.Text = "";
            lblTax.Text = "";
            lblPayAmount.Text = "";
            txtPrice.Focus();
        }
    }
}
