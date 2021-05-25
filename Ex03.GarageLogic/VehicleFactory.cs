using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public abstract class VehicleFactory
    {
        public static Vehicle InitVehicle(Garage.eVehicleTypes i_VehicleType)
        {
            Vehicle newVehicle = null;

            switch (i_VehicleType)
            {
                case Garage.eVehicleTypes.FuelMotorcycle:
                    newVehicle = new FuelMotorcycle();
                    break;
                case Garage.eVehicleTypes.ElectricMotorcycle:
                    newVehicle = new ElectricMotorcycle();
                    break;
                case Garage.eVehicleTypes.FuelCar:
                    newVehicle = new FuelCar();
                    break;
                case Garage.eVehicleTypes.ElectricCar:
                    newVehicle = new ElectricCar();
                    break;
                case Garage.eVehicleTypes.FuelTruck:
                    newVehicle = new Truck();
                    break;
            }

            return newVehicle;
        }
    }
}
