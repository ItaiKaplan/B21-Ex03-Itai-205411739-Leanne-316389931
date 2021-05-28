using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class ElectricMotorcycle : Motorcycle
    {
        const float k_MaxBatteryLife = (float)1.8;

        public ElectricMotorcycle()
            :base()
        {
            this.Engine = new ElectricEngine(k_MaxBatteryLife);
        }
    }
}
