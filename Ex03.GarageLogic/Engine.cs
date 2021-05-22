using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public abstract class Engine
    {
        readonly protected float r_MaxCapacity = 0;
        float m_CurrentCapacity = 0;

        public float MaxCapacity
        {
            get
            {
                return r_MaxCapacity;
            }
        }
        public float CurrentCapacity
        {
            get
            {
                return m_CurrentCapacity;
            }

            set
            {
                m_CurrentCapacity = value;
            }
        }

        public Engine(float i_MaxCapacity)
        {
            r_MaxCapacity = i_MaxCapacity;
        }

        public abstract void RefillEnergySource(float i_GasAmountToFill);


    }
}
