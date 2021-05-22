using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class FuelCar : Car
    {
        const FuelEngine.eFuelType k_FuelCarFuelType = FuelEngine.eFuelType.Octan95;
        const float k_FuelCarMaxCapacityTank = 45;

        public FuelCar()
            :base()
        {
            this.Engine = new FuelEngine(k_FuelCarFuelType, k_FuelCarMaxCapacityTank);
        }



    }
}
