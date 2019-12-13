/*
 * Author: Bilal Ahmad
 * Date: December 07, 2019
 * Purpose: Calculate the amount to pay for energy used by three type of customers:
 *      Residential, Commercial and Industrial.
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

namespace BilalAhmad_CPRG200_Lab1
{
    public partial class CustomerBill : Form
    {
        // Form level variables
        // constants 
        const decimal RESIDENTIAL_BASE = 6.00m; // residential base cost even if 0 kwh is used
        const decimal COMMERCIAL_FLAT_RATE = 60.00m; // flat rate for commercial energy usage for the first 1000kwh
        const decimal INDUSTRIAL_PEAK_FLAT_RATE = 76.00m; // flat rate for energy used during peak hours for the first 1000kwh
        const decimal INDUSTRIAL_OFF_PEAK_FLAT_RATE = 40.00m; // flat rate for energy used during off-peak hours for the first 1000kwh

        const decimal ENERGY_USED_UNDER_FLAT = 1000; // the threshold for energy used under flat, excess will be charged by the unit

        const decimal RESIDENTIAL_UNIT_RATE = 0.052m;// unit rate for energy used
        const decimal COMMERCIAL_UNIT_RATE = 0.045m;// unit rate for energy used over 1000
        const decimal PEAK_UNIT_RATE = 0.065m;// unit rate for peak energy used over 1000
        const decimal OFF_PEAK_UNIT_RATE = 0.028m;// unit rate for off-peak energy used over 1000

        public CustomerBill()
        {
            InitializeComponent();


            // When the form loads, Hide labels and Textboxes for peak and off peak hours.
            // because the default selection is residential.
            lblPeakHours.Visible = false;
            lblOffPeakHours.Visible = false;
            txtPeakHours.Visible = false;
            txtOffPeakHours.Visible = false;
            lblPeakHourskwh.Visible = false;
            lblOffPeakkwh.Visible = false;
        }

        // When calculate button is clicked
        private void btnCalculate_Click(object sender, EventArgs e)
        {      
            // local variables
            decimal energyUsedOverFlat = 0; 
            decimal chargeAmount = 0;

            /* if residential or commercial customer type radio buttons are checked this if statement runs.
             * Since residential and commercial both use the same energy used field, they are both wrapped in one if statement
             * */
            if (radResidential.Checked || radCommercial.Checked)
            {
                //validates if the field (Energy used) contains a value and then validates that the value is a positive whole number.
                //takes the input from energy used textBox and stores it in a decimal variable
                if (Validator.IsPresent(txtEnergy, "Energy Used") && Validator.IsNonNegativeInt32(txtEnergy, "Energy Used"))
                {
                    decimal energyUsed = Convert.ToDecimal(txtEnergy.Text);

                    // when the residential customer type is selected
                    // calculates the amount charged by calling a method and passing in base rate, the energy units to charge and the rate per unit
                    if (radResidential.Checked) 
                    {
                        chargeAmount = calculateChargeAmount(RESIDENTIAL_BASE, energyUsed, RESIDENTIAL_UNIT_RATE);
                    }

                    // when commercial cusotmer type is selected
                    
                    else if (radCommercial.Checked) 
                    {
                        // energy used is less than or equal to 1000
                        // the amount charged is a flat rate
                        if (energyUsed <= ENERGY_USED_UNDER_FLAT) 
                        {
                            chargeAmount = COMMERCIAL_FLAT_RATE; 
                        }
                        // if more than 1000 units are used
                        else
                        {
                            energyUsedOverFlat = energyUsed - ENERGY_USED_UNDER_FLAT; // calculates the units over 1000

                            // amount charged is calculated by calling calculateChargeAmount method
                            chargeAmount = calculateChargeAmount(COMMERCIAL_FLAT_RATE, energyUsedOverFlat, COMMERCIAL_UNIT_RATE);
                        }
                    }

                    // displays the amount charged by calling display amount and passing in the amount calculated in previous steps
                    // which is then shown in the amount charge field
                    displayAmount(chargeAmount);
                }

            }
            /*
             * When the industrial customer type is checked, this statement runs
             * This is seperated from the top if condition because industrial used peak and off-peak hours energy used rather than total energy used.
             * 
             */
            else if (radIndustrial.Checked)
            {
                // validates if peak hours and off peak hours fields have a value and that the value is a positive whole number.
                if (Validator.IsPresent(txtPeakHours, "Peak Hours") && Validator.IsNonNegativeInt32(txtPeakHours, "Peak Hours") &&
                    Validator.IsPresent(txtOffPeakHours, "Off-Peak Hours") && Validator.IsNonNegativeInt32(txtOffPeakHours, "Off-Peak Hours"))
                {
                    decimal peakHours = Convert.ToDecimal(txtPeakHours.Text); // stores peak hours input from txtpeakhours textbox in a decimal peakhours variable
                    decimal offPeakHours = Convert.ToDecimal(txtOffPeakHours.Text); // stores off-peak hours input from txtoffpeakhours textbox in a decimal offpeakhours variable

                    decimal peakHoursEnergyOverFlat = peakHours - ENERGY_USED_UNDER_FLAT; // calculates peak hours energy used units over the 1000
                    decimal OffPeakHoursOverFlat = offPeakHours - ENERGY_USED_UNDER_FLAT; // calculates off-peak hours energy used units over the 1000

                    //initialize local peak and off-peak charge amount variables
                    decimal peakChargeAmount = 0; // variable to keep track of the peak energy used charge amount.
                    decimal offPeakChargeAmount = 0; // variable to keep track of the off- peak energy used charge amount 

                    // when peak hours energy used is less than or equal to 1000,charge amount is a flat rate
                    if (peakHours <= ENERGY_USED_UNDER_FLAT) 
                    {

                        peakChargeAmount = INDUSTRIAL_PEAK_FLAT_RATE;  
                    }
                    // if more peak hours energy is used
                    // call calculatechargeabmount method and pass in parameters to calculate amount to charge.

                    else
                    {
                        peakChargeAmount = calculateChargeAmount(INDUSTRIAL_PEAK_FLAT_RATE, peakHoursEnergyOverFlat, PEAK_UNIT_RATE);
                    }
                    // when off-peak hours energy used is less than or equal to 1000
                    // off peak charge amount is a flat rate
                    if (offPeakHours <= ENERGY_USED_UNDER_FLAT) 
                    {
                        offPeakChargeAmount = INDUSTRIAL_OFF_PEAK_FLAT_RATE; 
                    }
                    // if more than 1000 kwh is used
                    // calls calculatechargeamount and passes in the variables to calculate amount to charge
                    else
                    {                        
                        offPeakChargeAmount = calculateChargeAmount(INDUSTRIAL_OFF_PEAK_FLAT_RATE, OffPeakHoursOverFlat, OFF_PEAK_UNIT_RATE);
                    }

                    // the total charge amount for industrial customer is the sum of the peak hours and off peak hours charge amount.
                    chargeAmount = peakChargeAmount + offPeakChargeAmount;

                    // calls displayamount method and passess in the total charge amount to be displayed in the amount charge field.
                    displayAmount(chargeAmount);
                }

            }

        }

        // this method displays the passed in amount in the charge amount field in the form. 
        private void displayAmount(decimal chargeAmount)
        {
            txtAmount.Text = chargeAmount.ToString("c"); // changes the amount passed in and converts it to string of type currency and shows it in the txtAmount field.
        }

        // this method calculates the charge amount and takes in three parameters: 
        // The flat rate parameter is different for all customer types and 
        // the energychargebyunit parameter is the energy used over the flat threshold,
        // the unitRate is the price per unit (applied to excess energy only)
        private decimal calculateChargeAmount(decimal flatRate, decimal energyChargeByUnit, decimal unitRate)
        {
            // the charge amount is calculated by multiplying the excess energy (energy over the flat threshold) by the unit rate 
            // and then adding it to the flat rate.
            decimal chargeAmount = flatRate + (energyChargeByUnit * unitRate);

            return chargeAmount; // returns the calculated charge amount
        }

        // clears all the fields to get ready for next calculation
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEnergy.Text = "";
            txtPeakHours.Text = "";
            txtOffPeakHours.Text = "";
            txtAmount.Text = "";
        }

        // this method, when triggered will close the form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // closes the current form
            Environment.Exit(0); // since this app has multiple forms, this.close will only close the current form. environment.exit will close the whole app. 
        }

        // when residential radio button is checked
        private void radResidential_CheckedChanged(object sender, EventArgs e)
        {
            displayFields("residential"); // calls display fields and passes the string "residential" to show only the required fields for residential customer type.
        }

        // when commercial radio button is checked
        private void radCommercial_CheckedChanged(object sender, EventArgs e)
        {
            displayFields("commercial"); // calls display field and passes the string "commercial" to show only the required fields for commercial customer type.
        }

        // when industrial customer type is checked
        private void radIndustrial_CheckedChanged(object sender, EventArgs e)
        {
            displayFields("industrial");// calls display field and passes the string "industrial" to show only the required fields for industrial customer type.
        }

        //method when called will display field according to the parameter (customertype) which is taken as a string
        private void displayFields(string customerType)
        {
            // customer type parameter is "residential" or "comemercial"
            // both are in one if statement because they both use the same fields
            if (customerType == "residential" || customerType == "commercial")
            {
                //hide these 
                lblPeakHours.Visible = false;
                lblOffPeakHours.Visible = false;
                txtPeakHours.Visible = false;
                txtOffPeakHours.Visible = false;
                lblPeakHourskwh.Visible = false;
                lblOffPeakkwh.Visible = false;

                //show these
                lblEnergyUsed.Visible = true;
                txtEnergy.Visible = true;
                lblEnergyUsedkwh.Visible = true;

                // set the focus on the energy used textBox
                txtEnergy.Focus();

            }

            // when customer type is "industrial"
            else if (customerType == "industrial")
            {
                //show these 
                lblPeakHours.Visible = true;
                lblOffPeakHours.Visible = true;
                txtPeakHours.Visible = true;
                txtOffPeakHours.Visible = true;
                lblPeakHourskwh.Visible = true;
                lblOffPeakkwh.Visible = true;

                //hide these
                lblEnergyUsed.Visible = false;
                txtEnergy.Visible = false;
                lblEnergyUsedkwh.Visible = false;

                //set focus to PeakHours textBox
                txtPeakHours.Focus();
            }


        }

    }//ends customberbill class

}//ends namespace
