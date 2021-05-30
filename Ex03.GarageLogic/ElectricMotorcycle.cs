namespace Ex03.GarageLogic
{
    public class ElectricMotorcycle : Motorcycle
    {
        private const float k_MaxBatteryLife = (float)1.8;

        public ElectricMotorcycle()
            : base()
        {
            this.Engine = new ElectricEngine(k_MaxBatteryLife);
        }

        public float MaxBattaryLife
        {
            get { return k_MaxBatteryLife; }
        }
    }
}
