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

        private const int k_NumberOfWheels = 2;
        private const int k_MaxWheelPressure = 30;
        private eLicenseType m_LicenseType;
        private int m_EngineVolume;

        public Motorcycle()
            : base()
        {
            for(int i = 0; i < k_NumberOfWheels; i++)
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

        public int MaxWheelPressure
        {
            get { return k_MaxWheelPressure; }
        }

        public int NumberOfWheels
        {
            get { return k_NumberOfWheels; }
        }

        public override string ToString()
        {
            string msg;

            msg = string.Format(
@"{0}
License Type: {1}
Engine Volume: {2}", 
base.ToString(), 
this.m_LicenseType, 
this.m_EngineVolume);

            return msg;
        }
    }
}
