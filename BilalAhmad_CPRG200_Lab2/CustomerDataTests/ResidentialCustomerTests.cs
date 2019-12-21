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
    public class ResidentialCustomerTests
    {
        //constructor test
        /*
        [TestMethod()]
        public void ResidentialCustomerTest()
        {
            Assert.Fail();
        }
        */

        //test calculate if the energy used is zero for residential customer type.
        [TestMethod()]
        public void CalculateChargeZeroAmount()
        {
            //arrange

            decimal resBase = 6m;
            decimal unitRate = 0.052m;
            decimal energyUsed = 0;
            decimal expectedCharge = 6m;
            decimal actualCharge = 0;
            ResidentialCustomer residentialCustomer = new ResidentialCustomer(1, "john", "R", actualCharge);
            //act
            actualCharge = residentialCustomer.CalculateCharge(resBase, unitRate, energyUsed);

            //assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        //test calculate if the energy used is more than zero for residential customer type.
        [TestMethod()]
        public void CalculateChargeMoreThanZero()
        {
            //arrange

            decimal resBase = 6m;
            decimal unitRate = 0.052m;
            decimal energyUsed = 100;
            decimal expectedCharge = 11.2m;
            decimal actualCharge = 0;
            ResidentialCustomer residentialCustomer = new ResidentialCustomer(1, "john", "R", actualCharge);
            //act
            actualCharge = residentialCustomer.CalculateCharge(resBase, unitRate, energyUsed);

            //assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }


    }
}