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
            decimal residentialBase = 6.00m;
            decimal commercialFlatRAte = 60.00m;
            decimal INDUSTRIAL_PEAK_FLAT_RATE = 76.00m;
            decimal INDUSTRIAL_OFF_PEAK_FLAT_RATE = 40.00m;


            decimal energyUsedUnderFlat = 1000;
            decimal energyUsedOverFlat = 0;

            decimal unitRate = 0;
            decimal chargeAmount = 0;
            if (radResidential.Checked || radCommercial.Checked)
            {
                decimal energyUsed = Convert.ToDecimal(txtEnergy.Text);


                if (radResidential.Checked)
                {

                    unitRate = Convert.ToDecimal(0.052);

                    chargeAmount = residentialBase + (unitRate * energyUsed);
                }
                else if (radCommercial.Checked)
                {
                    if (energyUsed <= 1000)
                    {
                        chargeAmount = commercialFlatRAte;
                    }
                    else
                    {

                        energyUsedOverFlat = energyUsed - energyUsedUnderFlat;
                        unitRate = Convert.ToDecimal(0.045);

                        chargeAmount = commercialFlatRAte + (energyUsedOverFlat * unitRate);


                    }
                }
            }
            else if (radIndustrial.Checked)
            {

                decimal peakHours = Convert.ToDecimal(txtPeakHours.Text);
                decimal offPeakHours = Convert.ToDecimal(txtOffPeakHours.Text);

                decimal peakHoursEnergyOverFlat = peakHours - energyUsedUnderFlat;
                decimal OffPeakHoursOverFlat = offPeakHours - energyUsedUnderFlat;

                decimal peakUnitRate = 0.065m;
                decimal offPeakUnitRate = 0.028m;

                decimal peakChargeAmount = 0;
                decimal offPeakChargeAmount = 0;

                if (peakHours <= 1000)
                {
                    
                    peakChargeAmount = INDUSTRIAL_PEAK_FLAT_RATE;
                }
                else
                {
                    peakChargeAmount = INDUSTRIAL_PEAK_FLAT_RATE + (peakHoursEnergyOverFlat * peakUnitRate);
                }

                if (offPeakHours <= 1000)
                {
                    offPeakChargeAmount = INDUSTRIAL_OFF_PEAK_FLAT_RATE;

                }
                else
                {
                    offPeakChargeAmount = INDUSTRIAL_OFF_PEAK_FLAT_RATE + (OffPeakHoursOverFlat * offPeakUnitRate);
                }

                if(peakHours == 0 || peakHours == null)
                {
                    peakChargeAmount = 0;
                } 
                if(offPeakHours == 0 || offPeakHours == null)
                {
                    offPeakChargeAmount = 0;
                }

                chargeAmount = peakChargeAmount + offPeakChargeAmount;

            }
            txtAmount.Text = chargeAmount.ToString("c");



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
