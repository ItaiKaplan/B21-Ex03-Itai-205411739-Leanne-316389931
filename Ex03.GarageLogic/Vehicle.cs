using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Vehicle 
    {
        string m_ModelName = string.Empty;
        string m_LicenseNumber = string.Empty;
        float m_RemainingEnergyPrecentage = 0;
        Engine m_Engine = null;
        List<Wheel> m_Wheels = new List<Wheel>();

        public string ModelName
        {
            get { return m_ModelName; }

            set { m_ModelName = value; }
        }

        public string LicenseNumber
        {
            get { return m_LicenseNumber; }

            set { m_LicenseNumber = value; }
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

        public List<Wheel> Wheels
        {
            get
            {
                return m_Wheels;
            }

            set
            {
                m_Wheels.Add(new Wheel(value));
            }
        }

    }
}
