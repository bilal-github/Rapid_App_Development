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
    public abstract class Customer
    {
        //private variables
        private int _accountNo;
        private string _customerName;
        private string _customerType;
        private decimal _chargeAmount;

        //public properties
        public int accountNo
        {
            get
            {
                return _accountNo;
            }
            set
            {
                _accountNo = value;
            }
        }
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
        public string customerName
        {
            get
            {
                return _customerName;
            }
            set
            {
                _customerName = value;
            }
        }
        public decimal chargeAmount
        {
            get
            {
                return _chargeAmount;
            }
            set
            {
                _chargeAmount = value;
            }
        }

        //public constructor for Customer
        public Customer(int accountNo, string customerName, string customerType, decimal chargeAmount)
        {
            this.accountNo = accountNo;
            this.customerName = customerName;
            this.customerType = customerType;
            this.chargeAmount = chargeAmount;
        }

        //Calculate charge method is abstract, as its different for every inherited class. 
        public abstract decimal CalculateCharge(decimal basePrice, decimal unitRate, decimal energyUsed);

        //To string method used by all inherited classes when adding customers to the List Box
        public override string ToString()
        {
            return accountNo.ToString() + " , " + customerName + " , " + customerType + " , " + chargeAmount.ToString();
        }

        // To CSV method used by CustomerDB when saving data to a txt file. 
        public string ToCSV()
        {
            return accountNo.ToString() + "," + customerName + "," + customerType + "," + chargeAmount.ToString();
        }
    }
}
