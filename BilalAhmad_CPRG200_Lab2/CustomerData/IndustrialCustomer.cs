using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    public class IndustrialCustomer : Customer
    {
        //private decimal industrialPeakFlatRate;
        //private decimal industrialOffPeakFlatRate;
        //private decimal peakUnitRate;
        //private decimal offPeakUnitRate;

        //private decimal peakEnergyExcess;
        //private decimal peakEnergyCharge;

        //private decimal offPeakEnergyExcess;
        //private decimal offPeakEnergyCharge;

        private decimal flatPrice;
        private decimal unitRate;
        private decimal energyExcess;
        

        decimal energyUsed;
        decimal chargeAmount;
        public IndustrialCustomer(int accountNo, string customerName) : base(accountNo, customerName)
        {

        }

        public decimal CalculatePeakOrOffPeakCharge(decimal indBase, decimal unitRate, decimal energyUsed)
        {
            this.flatPrice = indBase;
            this.unitRate = unitRate;
            this.energyUsed = energyUsed;
            if (energyUsed >= 1000)
            {
                energyExcess = energyUsed - 1000;
                chargeAmount = CalculateCharge(indBase, unitRate, energyExcess);
            }
            else
            {
                chargeAmount = CalculateCharge(indBase, unitRate, energyUsed);
            }

            return chargeAmount;
        }
        /*
        public decimal CalculatePeakEnergy(decimal peakBase, decimal peakUnitRate, decimal energyUsed)
        {
            this.industrialPeakFlatRate = peakBase;
            this.peakUnitRate = peakUnitRate;
            this.energyUsed = energyUsed;
            if (energyUsed >= 1000)
            {
                peakEnergyExcess = energyUsed - 1000;
                peakEnergyCharge = CalculateCharge(peakBase, peakUnitRate, peakEnergyExcess);
            }
            else
            {
                peakEnergyCharge = CalculateCharge(peakBase, peakUnitRate, energyUsed);
            }

            return peakEnergyCharge;
        }
        public decimal CalculateOffPeakEnergy(decimal offPeakBase, decimal offPeakUnitRate, decimal energyUsed)
        {
            this.industrialOffPeakFlatRate = offPeakBase;
            this.offPeakUnitRate = offPeakUnitRate;
            this.energyUsed = energyUsed;
            if (energyUsed >= 1000)
            {
                offPeakEnergyExcess = energyUsed - 1000;
                offPeakEnergyCharge = CalculateCharge(offPeakBase, peakUnitRate, peakEnergyExcess);
            }
            else
            {
                peakEnergyCharge = CalculateCharge(peakBase, peakUnitRate, energyUsed);
            }

            return peakEnergyCharge;
        }
        */ // peak and off peak methods


        //calculate charge amount based on the base price, unit rate and energyused
        public override decimal CalculateCharge(decimal baseCharge, decimal unitRate, decimal energyUsed)
        {           

            chargeAmount = baseCharge + (unitRate * energyUsed);

            return chargeAmount;
        }
    }
}
