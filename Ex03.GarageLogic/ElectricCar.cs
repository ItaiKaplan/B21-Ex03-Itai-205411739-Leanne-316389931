using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class ElectricCar : Car
    {
        const float k_MaxBatteryLife = (float)3.2;

        public ElectricCar()
            :base()
        {
            this.Engine = new ElectricEngine(k_MaxBatteryLife);
        }

        public override string ToString()
        {
            string msg;

            msg = string.Format(
@"This Vehicle is: Electric Car
{0}", base.ToString());

            return msg;
        }
    }
}
