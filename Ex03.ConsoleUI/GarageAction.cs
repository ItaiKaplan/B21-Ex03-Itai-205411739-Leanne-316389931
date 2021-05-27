using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
    class GarageAction
    {
        Garage m_Garage;

        public void AddVehicleToGarage()
        {
            Vehicle vehicle;
            Garage.eVehicleTypes vehicleType;
            float remainingEnergy;

            vehicleType = InputValidation.GetVehicleType();
            vehicle = VehicleFactory.InitVehicle(vehicleType);
            vehicle.ModelName = InputValidation.GetString();
            vehicle.LicenseNumber = InputValidation.GetString();
            vehicle.VehicleInfo = setVehicleInfo();

            setEnergy(vehicle);
            setWheelInfo(vehicle);
            setExtraDetailes(vehicle);


        }

        private VehicleGarageInfo setVehicleInfo()
        {
            string ownerName = InputValidation.GetString();
            string ownerNumber = InputValidation.GetString();
            return new VehicleGarageInfo(ownerName, ownerNumber);
        }

        private setEnergy(Vehicle i_Vehicle)
        {
            if(i_Vehicle.Engine is FuelEngine)
            {
                setFuel(i_Vehicle);
            } 
            else
            {
               
            }
        }

        private void setFuel(Vehicle i_Vehicle)
        {
            FuelEngine.eFuelType fuelType;
            float fuelAmount;
            FuelEngine fuelEngine = i_Vehicle.Engine as FuelEngine;

            try
            {
                fuelType = (FuelEngine.eFuelType)InputValidation.GetIntFromEnum();
                fuelAmount = InputValidation.GetFloat();
                fuelEngine.FillFuel(fuelType, fuelAmount);
            } catch(Exception ex)
            {
                OutputUser.Print(ex.Message);
                setFuel(i_Vehicle);
            }
            

        }

        private void setWheelInfo(Vehicle i_Vehicle)
        {
            float airInput;
            string wheelManufacture;

            wheelManufacture = InputValidation.GetString();
            airInput = InputValidation.GetFloat();
            foreach(Wheel wheel in i_Vehicle.Wheels)
            {
                wheel.InflateWheel(airInput);
                wheel.ManufacturerName = wheelManufacture;
            }
        }

        private void setExtraDetailes(Vehicle i_Vehicle)
        {
            if(i_Vehicle is Car)
            {
                setCarInfo(i_Vehicle as Car);
            } 
            else if(i_Vehicle is Motorcycle)
            {
                setMotorcycleInfo(i_Vehicle as Motorcycle);
            }
            else if(i_Vehicle is Truck)
            {
                setTruckInfo(i_Vehicle as Truck);
            }
        }

        private void setCarInfo(Car i_Car)
        { 
            i_Car.Color = (Car.eColor)InputValidation.GetIntFromEnum();
            i_Car.NumberOfDoors = (Car.eNumberOfDoors)InputValidation.GetIntFromEnum();
        }

        private void setMotorcycleInfo(Motorcycle i_Motorcycle)
        {
            i_Motorcycle.ModelName = InputValidation.GetString();
            i_Motorcycle.EngineVolume = InputValidation.GetFloat();
        }

        private void setTruckInfo(Truck i_Truck)
        {
            i_Truck.ContainsDangerousMaterials = InputValidation.GetBool;
            i_Truck.MaxCarryWeight = InputValidation.GetFloat();
        }

    }
}
