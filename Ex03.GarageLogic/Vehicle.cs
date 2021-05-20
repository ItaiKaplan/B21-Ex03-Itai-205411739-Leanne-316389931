using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public abstract class Vehicle 
    {
        string m_ModelName;
        string m_LicenseNumber;
        float m_RemainingEnergyPrecentage;
        Engine m_Engine;
        Dictionary<int, Wheel> m_Wheels;

        public string ModelName
        {
            get
            {
                return m_ModelName;
            }

            set
            {
                m_ModelName = value;
            }
        }

        public string LicenseNumber
        {
            get
            {
                return m_LicenseNumber;
            }

            set
            {
                m_LicenseNumber = value;
            }
        }

        public float RemainingEnergyPrecentage
        {
            get
            {
                return m_RemainingEnergyPrecentage;
            }

            set
            {
                m_RemainingEnergyPrecentage = value;
            }
        }

        public Engine Engine
        {
            get
            {
                return m_Engine;
            }

            set
            {
                m_Engine = value;
            }
        }

        public  Dictionary<int, Wheel> WheelsDict
        {
            get
            {
                return m_Wheels;
            }

            set
            {
                m_Wheels = value;
            }
        }

    }
}
