using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    
    public class ResidentialCustomer : Customer
    {
        private decimal residentialBase;
        private decimal residentialBaseUnitRate;
        decimal energyUsed;
        decimal chargeAmount;
        public ResidentialCustomer(int accountNo, string customerName) : base(accountNo, customerName)
        {

        }

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
