namespace Ex03.GarageLogic
{
    public abstract class Car : Vehicle
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

        private const int k_NumberOfWheels = 4;
        private const int k_MaxWheelPressure = 32;
        private eColor m_Color;
        private eNumberOfDoors m_NumberOfDoors;

        public Car()
            : base()
        { 
            for(int i = 0; i < k_NumberOfWheels; i++)
            {
                base.AddWheel(new Wheel(k_MaxWheelPressure));
            }
        }

        public eColor Color
        {
            get { return m_Color; }

            set
            {
                m_Color = value;
            }
        }

        public eNumberOfDoors NumberOfDoors
        {
            get { return m_NumberOfDoors; }

            set { m_NumberOfDoors = value; }
        }

        public override string ToString()
        {
            string msg;

            msg = string.Format(
@"{0},
Number of doors: {1}
Color: {2}", 
base.ToString(),
m_NumberOfDoors, 
this.m_Color);

            return msg;
        }
    }
}
