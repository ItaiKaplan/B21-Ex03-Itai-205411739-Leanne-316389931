namespace Ex03.GarageLogic
{
    public class ElectricEngine : Engine
    { 
        public ElectricEngine(float i_MaxCapacity)
            : base(i_MaxCapacity)
        {
        }

        public void FillEnergy(float i_AmountOfEnergyToAdd)
        {
            RefillEnergySource(i_AmountOfEnergyToAdd / 60 , true);
        }
    }
}
