using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class FuelCar : Car
    {
        public FuelCar()
        {
            this.Engine = new FuelEngine();
            this.Engine.MaxCapacity = 45;
            this.Engine.FuelType = FuelEngine.eFuelType.Octan95;
        }
    }
}
