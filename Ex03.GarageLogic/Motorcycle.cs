using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public abstract class Motorcycle : Vehicle
    {
        public enum eLicenseType
        {
            A = 1,
            B1 = 2,
            AA = 3,
            BB = 4
        }

        const int k_NumberOfWheels = 2;
        const int k_MaxWheelPressure = 30;
        eLicenseType m_LicenseType;
        int m_EngineVolume;

        public Motorcycle()
            : base()
        {
            for (int i = 0; i < k_NumberOfWheels; i++)
            {
                this.AddWheel(new Wheel(k_MaxWheelPressure));
            }
        }

        public eLicenseType LicenseType
        {
            get { return m_LicenseType; }
            set { m_LicenseType = value; }
        }

        public int EngineVolume
        {
            get { return m_EngineVolume; }
            set { m_EngineVolume = value; }
        }

        public override string ToString()
        {
            string msg;

            msg = string.Format(
@"{0}
License Type: {1}
Engine Volume: {2}", base.ToString(), m_LicenseType, m_EngineVolume);

            return msg;
        }




    }
}
