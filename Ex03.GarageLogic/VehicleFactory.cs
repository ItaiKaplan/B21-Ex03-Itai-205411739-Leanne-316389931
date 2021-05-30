namespace Ex03.GarageLogic
{
    public abstract class VehicleFactory
    {
        public enum eVehicleTypes
        {
            FuelCar = 1,
            ElectricCar = 2,
            FuelMotorcycle = 3,
            ElectricMotorcycle = 4,
            Truck = 5
        }

        public static Vehicle InitVehicle(eVehicleTypes i_VehicleType)
        {
            Vehicle newVehicle = null;

            switch(i_VehicleType)
            {
                case eVehicleTypes.FuelCar:
                    newVehicle = new FuelCar();
                    break;
                case eVehicleTypes.ElectricCar:
                    newVehicle = new ElectricCar();
                    break;
                case eVehicleTypes.FuelMotorcycle:
                    newVehicle = new FuelMotorcycle();
                    break;
                case eVehicleTypes.ElectricMotorcycle:
                    newVehicle = new ElectricMotorcycle();
                    break;
                case eVehicleTypes.Truck:
                    newVehicle = new Truck();
                    break;
            }

            return newVehicle;
        }
    }
}
