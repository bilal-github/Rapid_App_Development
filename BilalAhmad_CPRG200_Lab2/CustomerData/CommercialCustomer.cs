using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    public class CommercialCustomer : Customer
    {
        private decimal commercialBase;
        private decimal commercialBaseUnitRate;
        private decimal energyExcess;
        decimal energyUsed;
        decimal chargeAmount;
        public CommercialCustomer(int accountNo, string customerName) : base(accountNo, customerName)
        {

        }

        public override decimal CalculateCharge(decimal comBase, decimal comUnitRate, decimal energyUsed)
        {
            this.commercialBase = comBase;
            this.commercialBaseUnitRate = comUnitRate;
            this.energyUsed = energyUsed;

            if (energyUsed >= 1000)
            {
                energyExcess = energyUsed - 1000;
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
