using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public abstract class VehicleFactory
    {
        public enum eVehicleTypes
        {
            FuelMotorcycle = 1,
            ElectricMotorcycle = 2,
            FuelCar = 3,
            ElectricCar = 4,
            FuelTruck = 5
        }
        public static Vehicle InitVehicle(eVehicleTypes i_VehicleType)
        {
            Vehicle newVehicle = null;

            switch (i_VehicleType)
            {
                case eVehicleTypes.FuelMotorcycle:
                    newVehicle = new FuelMotorcycle();
                    break;
                case eVehicleTypes.ElectricMotorcycle:
                    newVehicle = new ElectricMotorcycle();
                    break;
                case eVehicleTypes.FuelCar:
                    newVehicle = new FuelCar();
                    break;
                case eVehicleTypes.ElectricCar:
                    newVehicle = new ElectricCar();
                    break;
                case eVehicleTypes.FuelTruck:
                    newVehicle = new Truck();
                    break;
            }

            return newVehicle;
        }
    }
}
