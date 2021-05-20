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
    }
}
