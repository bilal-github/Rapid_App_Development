using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRoll
{
    public partial class frmPayRoll : Form
    {
        public frmPayRoll()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal hoursWorked = Convert.ToDecimal(txtHoursWorked.Text);
            decimal hourlyRate = Convert.ToDecimal(txtHourlyRate.Text);

            decimal regularHoursWorked;
            decimal overTimeHoursWorked;

            const decimal threshold = 37.5m;
            const decimal overTimeRate = 1.5m;

            decimal regularPay;
            decimal overTimePay;
            decimal totalPayAmount;

            
            if(hoursWorked > threshold)//overtime done
            {
                regularHoursWorked = threshold;//regular hours //37.5
                overTimeHoursWorked = hoursWorked - threshold;//overtime hours//0.5

                regularPay = regularHoursWorked * hourlyRate;//37.5*10
                overTimePay = overTimeHoursWorked * (hourlyRate * overTimeRate);//0.5*(10*1.5)

                totalPayAmount = regularPay + overTimePay;



                txtRegularPay.Text = (regularPay).ToString("c");
                txtOvertimePay.Text = (overTimePay).ToString("c");
                txtTotalPayAmount.Text = (totalPayAmount).ToString("c");
                txtOvertimePay.Visible = true;
                lblOvertimePay.Visible = true;

            }
            else
            {
                regularPay = hoursWorked * hourlyRate;
                totalPayAmount = regularPay;

                txtRegularPay.Text = (regularPay).ToString("c");
                txtTotalPayAmount.Text = (totalPayAmount).ToString("c");
                txtOvertimePay.Visible = false;
                lblOvertimePay.Visible = false;

            }

            
            

        }
    }
}
