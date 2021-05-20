using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class Motorcycle : Vehicle
    {
        enum eLicenseType
        {
            A,
            B1,
            AA,
            BB
        }

        eLicenseType m_LicenseType;
        int m_EngineVolume;
    }
}
