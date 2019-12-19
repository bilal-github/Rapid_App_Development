using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    public abstract class Customer
    {
        private int accountNo;
        private string customerName;
        //private string customerType;

        //private decimal basePrice;
        //private decimal unitRate;
        //private decimal energyUsed;

        //private decimal chargeAmount;

        public Customer(int accountNo, string customerName)
        {
            this.accountNo = accountNo;
            this.customerName = customerName;
        }

        public abstract decimal CalculateCharge(decimal basePrice, decimal unitRate, decimal energyUsed);              
    }
}
