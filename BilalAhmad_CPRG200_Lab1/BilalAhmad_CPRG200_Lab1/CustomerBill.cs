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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



            lblPeakHours.Visible = false;
            lblOffPeakHours.Visible = false;
            txtPeakHours.Visible = false;
            txtOffPeakHours.Visible = false;
            lblPeakHourskwh.Visible = false;
            lblOffPeakkwh.Visible = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            const decimal RESIDENTIAL_BASE = 6.00m;
            const decimal COMMERCIAL_FLAT_RATE = 60.00m;
            const decimal INDUSTRIAL_PEAK_FLAT_RATE = 76.00m;
            const decimal INDUSTRIAL_OFF_PEAK_FLAT_RATE = 40.00m;


            const decimal ENERGY_USED_UNDER_FLAT = 1000;

            const decimal RESIDENTIAL_UNIT_RATE = 0.052m;
            const decimal COMMERCIAL_UNIT_RATE = 0.045m;
            const decimal PEAK_UNIT_RATE = 0.065m;
            const decimal OFF_PEAK_UNIT_RATE = 0.028m;

            decimal energyUsedOverFlat = 0;



            decimal unitRate = 0;
            decimal chargeAmount = 0;
            if (radResidential.Checked || radCommercial.Checked)
            {
                if (Validator.IsPresent(txtEnergy, "Energy Used") && Validator.IsNonNegativeInt32(txtEnergy, "Energy Used"))
                {
                    decimal energyUsed = Convert.ToDecimal(txtEnergy.Text);
                    if (radResidential.Checked)
                    {
                        chargeAmount = calculateChargeAmount(RESIDENTIAL_BASE, energyUsed, RESIDENTIAL_UNIT_RATE);
                    }
                    else if (radCommercial.Checked)
                    {
                       
                        if (energyUsed <= ENERGY_USED_UNDER_FLAT)
                        {
                            chargeAmount = COMMERCIAL_FLAT_RATE;
                        }
                        else
                        {
                            energyUsedOverFlat = energyUsed - ENERGY_USED_UNDER_FLAT;

                            chargeAmount = calculateChargeAmount(COMMERCIAL_FLAT_RATE, energyUsedOverFlat, COMMERCIAL_UNIT_RATE);
                        }
                    }
                    displayAmount(chargeAmount);
                }

            }
            else if (radIndustrial.Checked)
            {
                if (Validator.IsPresent(txtPeakHours, "Peak Hours") && Validator.IsNonNegativeInt32(txtPeakHours, "Peak Hours") &&
                    Validator.IsPresent(txtOffPeakHours, "Off-Peak Hours") && Validator.IsNonNegativeInt32(txtOffPeakHours, "Off-Peak Hours"))
                {
                    decimal peakHours = Convert.ToDecimal(txtPeakHours.Text);
                    decimal offPeakHours = Convert.ToDecimal(txtOffPeakHours.Text);

                    decimal peakHoursEnergyOverFlat = peakHours - ENERGY_USED_UNDER_FLAT;
                    decimal OffPeakHoursOverFlat = offPeakHours - ENERGY_USED_UNDER_FLAT;

                    decimal peakChargeAmount = 0;
                    decimal offPeakChargeAmount = 0;

                   if (peakHours <= ENERGY_USED_UNDER_FLAT)
                    {

                        peakChargeAmount = INDUSTRIAL_PEAK_FLAT_RATE;
                    }
                    else
                    {
                        peakChargeAmount = calculateChargeAmount(INDUSTRIAL_PEAK_FLAT_RATE, peakHoursEnergyOverFlat, PEAK_UNIT_RATE);
                    }

                    if (offPeakHours <= ENERGY_USED_UNDER_FLAT)
                    {
                        offPeakChargeAmount = INDUSTRIAL_OFF_PEAK_FLAT_RATE;
                    }
                    else
                    {
                        offPeakChargeAmount = calculateChargeAmount(INDUSTRIAL_OFF_PEAK_FLAT_RATE, OffPeakHoursOverFlat, OFF_PEAK_UNIT_RATE);
                    }

                    //if (peakHours == 0 || peakHours == null)
                    //{
                    //    peakChargeAmount = 0;
                    //}
                    //if (offPeakHours == 0 || offPeakHours == null)
                    //{
                    //    offPeakChargeAmount = 0;
                    //}

                    chargeAmount = peakChargeAmount + offPeakChargeAmount;
                    displayAmount(chargeAmount);
                }


            }
            
        }

        private void displayAmount(decimal chargeAmount)
        {
            txtAmount.Text = chargeAmount.ToString("c");

        }

        private decimal calculateChargeAmount(decimal flatRate, decimal energyChargeByUnit, decimal unitRate)
        {
            decimal chargeAmount = flatRate + (energyChargeByUnit * unitRate);

            return chargeAmount;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEnergy.Text = "";
            txtPeakHours.Text = "";
            txtOffPeakHours.Text = "";
            txtAmount.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radResidential_CheckedChanged(object sender, EventArgs e)
        {
            lblPeakHours.Visible = false;
            lblOffPeakHours.Visible = false;
            txtPeakHours.Visible = false;
            txtOffPeakHours.Visible = false;
            lblPeakHourskwh.Visible = false;
            lblOffPeakkwh.Visible = false;

            lblEnergyUsed.Visible = true;
            txtEnergy.Visible = true;
            lblEnergyUsedkwh.Visible = true;

            txtEnergy.Focus();
        }

        private void radCommercial_CheckedChanged(object sender, EventArgs e)
        {
            lblPeakHours.Visible = false;
            lblOffPeakHours.Visible = false;
            txtPeakHours.Visible = false;
            txtOffPeakHours.Visible = false;
            lblPeakHourskwh.Visible = false;
            lblOffPeakkwh.Visible = false;

            lblEnergyUsed.Visible = true;
            txtEnergy.Visible = true;
            lblEnergyUsedkwh.Visible = true;

            txtEnergy.Focus();
        }

        private void radIndustrial_CheckedChanged(object sender, EventArgs e)
        {
            lblPeakHours.Visible = true;
            lblOffPeakHours.Visible = true;
            txtPeakHours.Visible = true;
            txtOffPeakHours.Visible = true;
            lblPeakHourskwh.Visible = true;
            lblOffPeakkwh.Visible = true;

            lblEnergyUsed.Visible = false;
            txtEnergy.Visible = false;
            lblEnergyUsedkwh.Visible = false;

            txtPeakHours.Focus();
        }
    }
}
