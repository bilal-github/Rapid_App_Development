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
        private string _customerType;

        //private decimal basePrice;
        //private decimal unitRate;
        //private decimal energyUsed;

        private decimal chargeAmount;

        public int accoutNo { get; set; }
        public string customerType
        {
            get
            {
                return _customerType;
            }
            set
            {
                _customerType = value;
            }
        }


        public Customer(int accountNo, string customerName)
        {
            this.accountNo = accountNo;
            this.customerName = customerName;
        }

        public Customer(int accountNo, string customerName, string customerType, decimal chargeAmount)
        {
            this.accountNo = accountNo;
            this.customerName = customerName;
            this.customerType = customerType;
            this.chargeAmount = chargeAmount;
        }

        public string getCustomerType()
        {

            return this.customerType;
        }

        public decimal getChargeAmount()
        {
            return this.chargeAmount;
        }

        public int getAccountNo()
        {
            return this.accountNo;
        }

        public string getCustomerName()
        {
            return this.customerName;
        }


        public abstract decimal CalculateCharge(decimal basePrice, decimal unitRate, decimal energyUsed);

        public override string ToString()
        {
            return accountNo.ToString() + " , " + customerName + " , " + customerType + " , " + chargeAmount.ToString();
        }

        public string ToCSV()
        {
            return accountNo.ToString() + "," + customerName + "," + customerType + "," + chargeAmount.ToString();

        }
    }
}
