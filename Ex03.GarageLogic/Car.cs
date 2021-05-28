namespace Ex03.GarageLogic
{
    public class Car : Vehicle
    {
        public enum eColor
        {
            Red = 1,
            Silver = 2,
            White = 3,
            Black = 4
        }

        public enum eNumberOfDoors
        {
            Two = 1,
            Three = 2,
            Four = 3,
            Five = 4
        }

        const int k_NumberOfWheels = 4;
        const int k_MaxWheelPressure = 32;
        eColor m_Color;
        eNumberOfDoors m_NumberOfDoors;

        public Car()
            : base()
        { 
            for(int i = 0; i < k_NumberOfWheels; i++)
            {
                AddWheel(new Wheel(k_MaxWheelPressure));
            }
        }

        public eColor Color
        {
            get
            {
                return m_Color;
            }

            set
            {
                m_Color = value;
            }
        }

        public eNumberOfDoors NumberOfDoors
        {
            get
            {
                return NumberOfDoors;
            }

            set
            {
                m_NumberOfDoors = value;
            }
        }

        public override string ToString()
        {
            string msg;

            msg = string.Format(
@"{0},
Number of doors: {1},
Color: {2}", base.ToString(), m_NumberOfDoors, m_Color);

            return msg;
        }
    }
}
