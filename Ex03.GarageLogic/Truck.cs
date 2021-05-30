namespace Ex03.GarageLogic
{
    public class Truck : Vehicle
    {
        private const int k_NumberOfWheels = 16;
        private const int k_MaxWheelPressure = 26;
        private const FuelEngine.eFuelType k_FuelType = FuelEngine.eFuelType.Soler;
        private const float k_FuelMaxCapacityTank = 120;
        private bool m_ContainsDangerousMaterials;
        private float m_MaxCarryWeight;

        public Truck()
            : base()
        {
            this.Engine = new FuelEngine(k_FuelType, k_FuelMaxCapacityTank);
            for(int i = 0; i < k_NumberOfWheels; i++)
            {
                this.AddWheel(new Wheel(k_MaxWheelPressure));
            }
        }

        public bool ContainsDangerousMaterials
        {
            get { return m_ContainsDangerousMaterials; }
            set { m_ContainsDangerousMaterials = value; }
        }

        public float MaxCarryWeight
        {
            get { return m_MaxCarryWeight; }
            set { m_MaxCarryWeight = value; }
        }

        public int MaxWheelPressure
        {
            get { return k_MaxWheelPressure; }
        }

        public int NumberOfWheels
        {
            get { return k_NumberOfWheels; }
        }

        public FuelEngine.eFuelType FuelType
        {
            get { return k_FuelType; }
        }

        public float MaxCapacityTank
        {
            get { return k_FuelMaxCapacityTank; }
        }

        public override string ToString()
        {
            string msg;

            msg = string.Format(
@"This Vehicle is: Fuel Truck
{0}
Fuel Type: {1}
Contains Dangerous Materials: {2}
MaxCarryWeight: {3}", 
base.ToString(), 
k_FuelType, 
this.m_ContainsDangerousMaterials, 
this.m_MaxCarryWeight);

            return msg;
        }
    }
}
