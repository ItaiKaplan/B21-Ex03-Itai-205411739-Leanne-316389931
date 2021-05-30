namespace Ex03.GarageLogic
{
    public class FuelMotorcycle : Motorcycle
    {
        private const FuelEngine.eFuelType k_FuelType = FuelEngine.eFuelType.Octan98;
        private const float k_FuelMaxCapacity = 6;

        public FuelMotorcycle()
            : base()
        {
            this.m_Engine = new FuelEngine(k_FuelType, k_FuelMaxCapacity);
        }

        public override string ToString()
        {
            string msg;
            msg = string.Format(
@"This Vehicle is: Fuel Motorcycle
{0}
Fuel Type: {1}", 
base.ToString(), 
k_FuelType);

            return msg;
        }
    }
}
