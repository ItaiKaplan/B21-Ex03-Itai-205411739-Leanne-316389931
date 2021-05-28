using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class FuelEngine : Engine
    {
        public enum eFuelType
        {
            Soler = 1,
            Octan95 = 2,
            Octan96 = 3,
            Octan98 = 4,
        }

        readonly eFuelType r_FuelType;

        public FuelEngine(eFuelType i_FuelType, float i_MaxCapacity)
            : base(i_MaxCapacity)
        {
            r_FuelType = i_FuelType;
        }

        public eFuelType FuelType
        {
            get { return r_FuelType; }
        }

        public void FillFuel(eFuelType i_FuelType, float i_AmountOfFuelToFill)
        {
            if(i_FuelType.Equals(r_FuelType))
            {
                RefillEnergySource(i_AmountOfFuelToFill);
            } else
            {
                throw new ArgumentException("Fuel type does not match!");
            }
        }



    }
}
