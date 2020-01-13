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

    public class ResidentialCustomer : Customer
    {
        //private variables.
        private decimal residentialBase;
        private decimal residentialBaseUnitRate;
        decimal energyUsed;
        decimal chargeAmount;

        //public constructor
        public ResidentialCustomer(int accountNo, string customerName, string customerType, decimal chargeAmount) :
            base(accountNo, customerName, customerType, chargeAmount)
        {

        }

        //Calculate charge for residential customer, returns chargeamount
        public override decimal CalculateCharge(decimal resBase, decimal resUnitRate, decimal energyUsed)
        {
            this.residentialBase = resBase;
            this.residentialBaseUnitRate = resUnitRate;
            this.energyUsed = energyUsed;

            chargeAmount = residentialBase + (residentialBaseUnitRate * energyUsed);

            return chargeAmount;
        }

    }
}
