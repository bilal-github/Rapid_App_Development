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
    public class CommercialCustomer : Customer
    {
        //form level variables
        const decimal ENERGY_USED_UNDER_FLAT = 1000; // the threshold for energy used under flat, excess will be charged by the unit

        private decimal commercialBase;
        private decimal commercialBaseUnitRate;
        private decimal energyExcess;
        decimal energyUsed;
        decimal chargeAmount;

        //public constructor
        public CommercialCustomer(int accountNo, string customerName, string customerType, decimal chargeAmount) :
            base(accountNo, customerName, customerType, chargeAmount)
        {

        }

        //calculate charge for CommercialCustomer, returns chargeamount
        public override decimal CalculateCharge(decimal comBase, decimal comUnitRate, decimal energyUsed)
        {
            //setting private variables
            this.commercialBase = comBase;
            this.commercialBaseUnitRate = comUnitRate;
            this.energyUsed = energyUsed;

            //if more than 1000 kwh is used
            if (energyUsed >= ENERGY_USED_UNDER_FLAT)
            {
                energyExcess = energyUsed - ENERGY_USED_UNDER_FLAT;
                chargeAmount = comBase + (comUnitRate * energyExcess);
            }
            else // if less than 1000kwh is used
            {
                chargeAmount = comBase;
            }
            return chargeAmount;

        }
    }
}
