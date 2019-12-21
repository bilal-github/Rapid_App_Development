using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData.Tests
{
    [TestClass()]
    public class IndustrialCustomerTests
    {
        //test calculate if the peak energy used is zero kwh for industrial customer type.
        [TestMethod()]
        public void CalculatePeakZeroAmount()
        {
            //arrange
            decimal peakBase = 76m;
            decimal unitRate = 0.065m;
            decimal energyUsed = 0;
            decimal expectedCharge = 76m;
            decimal actualCharge =0;
            IndustrialCustomer industrialCustomer = new IndustrialCustomer(1, "john", "I", actualCharge);

            //act
            actualCharge = industrialCustomer.CalculateCharge(peakBase, unitRate, energyUsed);

            //assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        //test calculate if the peak energy used is more than 1000 kwh for industrial customer type.
        [TestMethod()]
        public void CalculatePeakChargeOver1000Amount()
        {
            //arrange
            decimal peakBase = 76m;
            decimal unitRate = 0.065m;
            decimal energyUsed = 1010;
            decimal expectedCharge = 76.65m;
            decimal actualCharge = 0;
            IndustrialCustomer industrialCustomer = new IndustrialCustomer(1, "john", "I", actualCharge);

            //act
            actualCharge = industrialCustomer.CalculateCharge(peakBase, unitRate, energyUsed);

            //assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        //test calculate if the Off-peak energy used is zero kwh for industrial customer type.
        [TestMethod()]
        public void CalculateOffPeakZeroAmount()
        {
            //arrange
           
            decimal offPeakBase = 40m;
            decimal unitRate = 0.028m;
            decimal energyUsed = 0;
            decimal expectedCharge = 40m;
            decimal actualCharge = 0;
            IndustrialCustomer industrialCustomer = new IndustrialCustomer(1, "john", "I", actualCharge);

            //act
            actualCharge = industrialCustomer.CalculateCharge(offPeakBase, unitRate, energyUsed);

            //assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        //test calculate if the Off-peak energy used is more than 1000 kwh for industrial customer type.
        [TestMethod()]
        public void CalculateOffPeakChargeOver1000Amount()
        {
            //arrange
            decimal offPeakBase = 40m;
            decimal unitRate = 0.028m;
            decimal energyUsed = 1010;
            decimal expectedCharge = 40.28m;
            decimal actualCharge = 0;
            IndustrialCustomer industrialCustomer = new IndustrialCustomer(1, "john", "I", actualCharge);

            //act
            /*energy used is -1000 because its a flat rate till 1000, any energy over 1000 will
             * be charged at the unit rate
             */
            actualCharge = industrialCustomer.CalculateCharge(offPeakBase, unitRate, energyUsed); 

            //assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }
    }
}