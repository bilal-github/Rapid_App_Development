/*
 * Author: Bilal Ahmad
 * Description: Lab 2 Unit Tests for Commercial Customer Tests
 */
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
    public class CommercialCustomerTests
    {
        //test calculate if the energy used is zero kwh for commercial customer type.
        [TestMethod()]
        public void CalculateChargeZeroAmount()
        {
            //arrange
            decimal comBase = 60m;
            decimal unitRate = 0.045m;
            decimal energyUsed = 0;
            decimal expectedCharge = 60m;
            decimal actualCharge = 0;
            CommercialCustomer commercialCustomer = new CommercialCustomer(1, "john", "C", actualCharge);
            //act
            actualCharge = commercialCustomer.CalculateCharge(comBase, unitRate, energyUsed);

            //assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        //test calculate if the energy used is between zero and 1000 kwh for commercial customer type.
        [TestMethod()]
        public void CalculateChargeZeroTo1000Amount()
        {
            //arrange
            decimal comBase = 60m;
            decimal unitRate = 0.045m;
            decimal energyUsed = 10;
            decimal expectedCharge = 60m;
            decimal actualCharge = 0;
            CommercialCustomer commercialCustomer = new CommercialCustomer(1, "john", "C", actualCharge);

            //act
            actualCharge = commercialCustomer.CalculateCharge(comBase, unitRate, energyUsed);

            //assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        //test calculate if the energy used is more than 1000kwh for commercial customer type.
        [TestMethod()]
        public void CalculateChargeOver1000Amount()
        {
            //arrange
            decimal comBase = 60m;
            decimal unitRate = 0.045m;
            decimal energyUsed = 1010;
            decimal expectedCharge = 60.45m;
            decimal actualCharge = 0;
            CommercialCustomer commercialCustomer = new CommercialCustomer(1, "john", "C", actualCharge);

            //act
            actualCharge = commercialCustomer.CalculateCharge(comBase, unitRate, energyUsed);

            //assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }
    }
}