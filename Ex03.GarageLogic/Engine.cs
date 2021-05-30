namespace Ex03.GarageLogic
{
    public abstract class Engine
    {
        private readonly float r_MaxCapacity = 0;
        private float m_CurrentCapacity = 0;

        public Engine(float i_MaxCapacity)
        {
            r_MaxCapacity = i_MaxCapacity;
        }

        public float MaxCapacity
        {
            get { return r_MaxCapacity; }
        }

        public float CurrentCapacity
        {
            get { return m_CurrentCapacity; }
            set { m_CurrentCapacity = value; }
        }

        public void RefillEnergySource(float i_EnergyAmountToFill, bool i_IsElectric)
        {
            if(m_CurrentCapacity + i_EnergyAmountToFill <= r_MaxCapacity)
            {
                m_CurrentCapacity = m_CurrentCapacity + i_EnergyAmountToFill;
            } 
            else
            {
                if (i_IsElectric)
                {
                    throw new ValueOutOfRangeException(0, ((r_MaxCapacity - m_CurrentCapacity) * 60));
                }
                else
                {
                    throw new ValueOutOfRangeException(0, (r_MaxCapacity - m_CurrentCapacity));
                }
            }
        }
    }
}
