using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeTax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal salaryEntered = Convert.ToDecimal(txtSalary.Text);
            const decimal TAX_15 = 0.15m;
            const decimal TAX_18 = 0.18m;
            const decimal TAX_22 = 0.22m;
            const decimal TAX_27 = 0.27m;
            const decimal TAX_33 = 0.33m;

            decimal salaryAfterBaseTax = 0;
            decimal salaryAfterTax = 0;
            decimal salaryInExcess = 0;
            decimal taxRate = 0;






            if (salaryEntered >= 0m && salaryEntered <= 14999.99m)
            {
                salaryAfterBaseTax = salaryEntered;
                salaryAfterTax = salaryAfterBaseTax - (salaryAfterBaseTax * TAX_15);
                taxRate = TAX_15;

            }
            else if (salaryEntered >= 15000m && salaryEntered <= 29999.99m)
            {
                salaryAfterBaseTax = salaryEntered - 2250;
                salaryInExcess = salaryEntered - 14999.99m;
                //salaryAfterBaseTax = salaryEntered - (
                salaryAfterTax = salaryAfterBaseTax - (salaryInExcess * TAX_18);
                taxRate = TAX_18;
            }
            else if (salaryEntered >= 30000m && salaryEntered < 49999.99m)
            {
                salaryAfterBaseTax = salaryEntered - 4950;
                salaryInExcess = salaryEntered - 29999.99m;
                salaryAfterTax = salaryAfterBaseTax - (salaryInExcess * TAX_22);
                taxRate = TAX_22;
            }
            else if (salaryEntered >= 50000m && salaryEntered < 79999.99m)
            {
                salaryAfterBaseTax = salaryEntered - 9350;
                salaryInExcess = salaryEntered - 49999.99m;
                salaryAfterTax = salaryAfterBaseTax - (salaryInExcess * TAX_27);
                taxRate = TAX_27;
            }
            else if (salaryEntered >= 80000m)
            {
                salaryAfterBaseTax = salaryEntered - 17450;
                salaryInExcess = salaryEntered - 79999.99m;
                salaryAfterTax = salaryAfterBaseTax - (salaryInExcess * TAX_33);
                taxRate = TAX_33;
            }
            else
            {
                MessageBox.Show("Invalid entry");
            }

            txtTaxRate.Text = taxRate.ToString("p");
            txtSalaryAfterTax.Text = salaryAfterTax.ToString("c");
            //txtSalary.Text = salaryEntered.ToString("c");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
