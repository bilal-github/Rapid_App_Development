/*
 * Author: Bilal Ahmad
 * Description: Lab 2
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    public class IndustrialCustomer : Customer
    {
        //private variables
        const decimal ENERGY_USED_UNDER_FLAT = 1000; // the threshold for energy used under flat, excess will be charged by the unit
        private decimal flatPrice;
        private decimal unitRate;
        private decimal energyExcess;
        decimal energyUsed;
        decimal chargeAmount;

        //public constructor
        public IndustrialCustomer(int accountNo, string customerName, string customerType, decimal chargeAmount) :
            base(accountNo, customerName, customerType, chargeAmount)
        {
        }

        //calculate charge amount for Industrial (peak and offpeak), returns chargeAmount.
        //uses the energy used passed by the Calculate charge method below.
        public decimal CalculateChargeAmount(decimal baseCharge, decimal unitRate, decimal energyUsed)
        {
            chargeAmount = baseCharge + (unitRate * energyUsed);
            return chargeAmount;
        }

        //calculate charge amount based on the base price, unit rate and energyused
        public override decimal CalculateCharge(decimal peakOrOffPeakBaseCharge, decimal unitRate, decimal energyUsed)
        {
            this.flatPrice = peakOrOffPeakBaseCharge;
            this.unitRate = unitRate;
            this.energyUsed = energyUsed;
            if (energyUsed >= ENERGY_USED_UNDER_FLAT) // energy used is more than 1000kwh
            {
                energyExcess = energyUsed - ENERGY_USED_UNDER_FLAT;
                chargeAmount = CalculateChargeAmount(peakOrOffPeakBaseCharge, unitRate, energyExcess);
            }
            else // energy used is less than 1000kwh
            {
                energyUsed = 0;//if under 1000, the energy is used at a flat rate.
                chargeAmount = CalculateChargeAmount(peakOrOffPeakBaseCharge, unitRate, energyUsed);
            }

            return chargeAmount;

            
        }
    }
}
