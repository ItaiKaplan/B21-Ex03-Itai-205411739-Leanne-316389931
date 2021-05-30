namespace Ex03.GarageLogic
{
    public class Wheel
    {
        private readonly float r_MaxAirPressure;
        private string m_ManufacturerName = string.Empty;
        private float m_CurrentAirPressure;
        
        public Wheel(float i_MaxAirPressure)
        {
            r_MaxAirPressure = i_MaxAirPressure;
        }

        public string ManufacturerName
        {
            get
            {
                return m_ManufacturerName;
            }

            set
            {
                m_ManufacturerName = value;
            }
        }

        public float CurrentAirPressure
        {
            get { return m_CurrentAirPressure; }
        }

        public float MaxAirPressure
        {
            get { return r_MaxAirPressure; }
        }

        public void InflateWheel(float i_AirToAdd)
        {
            if(m_CurrentAirPressure + i_AirToAdd <= r_MaxAirPressure)
            {
                m_CurrentAirPressure += i_AirToAdd;
            }
            else
            {
                throw new ValueOutOfRangeException(0, r_MaxAirPressure);
            }
        }

        public void FillAirToMax()
        {
            m_CurrentAirPressure = r_MaxAirPressure;
        }

        public override string ToString()
        {
            string msg;

            msg = string.Format(
@"ManufacturerName: {0}
Air Pressure: {1} / {2}", 
m_ManufacturerName, 
m_CurrentAirPressure, 
r_MaxAirPressure);

            return msg;
        }
    }
}
