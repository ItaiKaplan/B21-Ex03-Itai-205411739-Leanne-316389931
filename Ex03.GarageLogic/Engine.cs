using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Engine
    {
        float m_MaxCapacity;
        float m_CurrentCapacity;

        public float MaxCapacity
        {
            get
            {
                return m_MaxCapacity;
            }

            set
            {
                m_MaxCapacity = value;
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

        public void RefillEnergySource(float i_GasAmountToFill)
        {

            if(this.CurrentCapacity + i_GasAmountToFill > this.MaxCapacity)
            {
                throw Exception;
            }
        }

    }
}
