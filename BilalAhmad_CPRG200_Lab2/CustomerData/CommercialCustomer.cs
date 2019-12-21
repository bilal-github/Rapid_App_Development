using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    public class CommercialCustomer : Customer
    {
        const decimal ENERGY_USED_UNDER_FLAT = 1000; // the threshold for energy used under flat, excess will be charged by the unit

        private decimal commercialBase;
        private decimal commercialBaseUnitRate;
        private decimal energyExcess;
        decimal energyUsed;
        decimal chargeAmount;
        public CommercialCustomer(int accountNo, string customerName, string customerType, decimal chargeAmount) :
            base(accountNo, customerName, customerType, chargeAmount)
        {

        }

        public override decimal CalculateCharge(decimal comBase, decimal comUnitRate, decimal energyUsed)
        {
            this.commercialBase = comBase;
            this.commercialBaseUnitRate = comUnitRate;
            this.energyUsed = energyUsed;


            if (energyUsed >= ENERGY_USED_UNDER_FLAT)
            {
                energyExcess = energyUsed - ENERGY_USED_UNDER_FLAT;
                chargeAmount = comBase + (comUnitRate * energyExcess);
            }
            else
            {
                chargeAmount = comBase;
            }
            return chargeAmount;

        }
    }
}
