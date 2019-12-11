using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversions
{
    public partial class Form1 : Form
    {
        const double CM_IN_INCH = 2.54;
        const int INCHES_IN_FOOT = 12;
        public Form1()
        {
            InitializeComponent();
        }

        //convert from imperial to metric
        // feet and inches to centimeters
        private void btnToMetric_Click(object sender, EventArgs e)
        {
            int feet, inches;
            double centimeters;
            if (Validator.IsPresent(txtFeet, "Feet") && Validator.IsNonNegativeInt32(txtFeet, "Feet") && 
                Validator.IsPresent(txtInches, "Inches") && Validator.IsNonNegativeInt32(txtInches, "Inches"))
            {
                //get feet and inches from user input
                feet = Convert.ToInt32(txtFeet.Text);
                inches = Convert.ToInt32(txtInches.Text);

                //calculate equivalent cm
                centimeters = CalculateCentimeters(feet, inches);

                //display centimeters
                txtCentimeters.Text = centimeters.ToString("f2");
            }

        }

        //convert feet and inches to centimeters
        private double CalculateCentimeters(int f, int i)
        {
            double cm = 0;
            int totalInches = f * INCHES_IN_FOOT + i;

            cm = totalInches * CM_IN_INCH;

            return cm;
        }

        //convert from metric to imperial
        private void btnToImperial_Click(object sender, EventArgs e)
        {
            double centimeters;
            int feet, inches;
            if (Validator.IsPresent(txtCentimeters, "centimeters") && 
                Validator.IsNonNegativeDouble(txtCentimeters, "centimeters"))
            {
                //get centimeters
                centimeters = Convert.ToDouble(txtCentimeters.Text);

                // calculate feet and inches
                CalculateFeetInches(centimeters, out feet, out inches);
                //display feet and inches
                txtFeet.Text = feet.ToString();
                txtInches.Text = inches.ToString();
            }

        }

        //converts cm to feet and inches
        private void CalculateFeetInches(double cm, out int f, out int i)
        {
            int totalInches = (int)Math.Round(cm / CM_IN_INCH); // typecasting result into int
            f = totalInches / INCHES_IN_FOOT;
            i = totalInches % INCHES_IN_FOOT;
        }
    }
}
