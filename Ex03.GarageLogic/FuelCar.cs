﻿namespace Ex03.GarageLogic
{
    public class FuelCar : Car
    {
        private const FuelEngine.eFuelType k_FuelType = FuelEngine.eFuelType.Octan95;
        private const float k_FuelCarMaxCapacityTank = 45;

        public FuelCar()
            : base()
        {
            this.Engine = new FuelEngine(k_FuelType, k_FuelCarMaxCapacityTank);
        }

        public FuelEngine.eFuelType FuelType
        {
            get { return k_FuelType; }
        }

        public float MaxCapacityTank
        {
            get { return k_FuelCarMaxCapacityTank; }
        }

        public override string ToString()
        {
            string msg;

            msg = string.Format(
@"This Vehicle is: Fuel Car
{0}
Fuel Type: {1}", 
base.ToString(), 
k_FuelType);

            return msg;
        }
    }
}