using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class FuelCar : Car
    {
        const FuelEngine.eFuelType k_FuelType = FuelEngine.eFuelType.Octan95;
        const float k_FuelCarMaxCapacityTank = 45;

        public FuelCar()
            :base()
        {
            this.Engine = new FuelEngine(k_FuelType, k_FuelCarMaxCapacityTank);
        }

        public override string ToString()
        {
            string msg;

            msg = string.Format(
@"This Vehicle is: Fuel Car
{0},
Fuel Type: {1}", base.ToString(), k_FuelType);

            return msg;
        }



    }
}
