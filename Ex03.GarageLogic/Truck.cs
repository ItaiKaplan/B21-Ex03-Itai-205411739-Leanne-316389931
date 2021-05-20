using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class Truck : Vehicle
    {
        Engine m_Engine;
        bool m_ContainsDangerousMaterials;
        float m_MaxCarryWeight;

        public Truck()
        {
            this.m_Engine = new FuelEngine();
            this.Engine.MaxCapacity = 120;
        }
    }
}
