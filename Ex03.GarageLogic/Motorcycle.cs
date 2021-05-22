using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Motorcycle : Vehicle
    {
        public enum eLicenseType
        {
            A,
            B1,
            AA,
            BB
        }

        eLicenseType m_LicenseType;
        int m_EngineVolume;

        public Motorcycle()
        {
            base();
            Dictionary<int,Wheel> WheelsDict = new Dictionary<int, Wheel>(2);
            WheelsDict.Add(1, new Wheel(30));
            WheelsDict.Add(1, new Wheel(30));
            this.WheelsDict = WheelsDict;
        }



        public eLicenseType LicenseType
        {
            get
            {
                return m_LicenseType;
            }

            set
            {
                m_LicenseType = value;
            }
        }

        public int EngineVolume
        {
            get
            {
                return m_EngineVolume;
            }

            set
            {
                m_EngineVolume = value; 
            }
        }




    }
}
