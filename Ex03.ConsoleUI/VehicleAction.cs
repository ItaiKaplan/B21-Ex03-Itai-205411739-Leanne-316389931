using System;
using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
    class VehicleAction
    {
        readonly Vehicle r_Vehicle;
        readonly Garage r_Garage;

        public VehicleAction(Vehicle i_Vehicle, Garage i_Garage)
        {
            r_Vehicle = i_Vehicle;
            r_Garage = i_Garage;
        }

        private void endAction()
        {
            UserConsole.SleepAndClear();
            MenuToUser.NextStepVehicleManu(r_Garage);
        }
        
        public void ChangeVehicleStatus()
        {
            try
            {
                VehicleGarageInfo.eVehicleCondition vehicleStatus = (VehicleGarageInfo.eVehicleCondition)InputValidation.EnumChoiseToInt(typeof(VehicleGarageInfo.eVehicleCondition), UserConsole.ChooseString("vehicle condition"));
                r_Garage.ChangeVehicleCondition(r_Vehicle.LicenseNumber, vehicleStatus);
            } catch (Exception ex)
            {
                UserConsole.Print(ex.Message);
            }

            endAction();
        }

        public void FillAirWheels()
        {
            r_Garage.FillAirToMax(r_Vehicle.LicenseNumber);
            endAction();
        }

        public void FillFuelVehicle()
        {
            while (true)
            {
                try
                {
                    FuelEngine.eFuelType fuelTypeInput = (FuelEngine.eFuelType)InputValidation.EnumChoiseToInt(typeof(FuelEngine.eFuelType), UserConsole.ChooseString("fuel type"));
                    float amountOfFuel = InputValidation.GetFloat("Enter the amount of fuel to fill");
                    r_Garage.FillFuelVehicle(r_Vehicle.LicenseNumber, fuelTypeInput, amountOfFuel);
                    break;
                }
                catch (Exception ex)
                {
                    UserConsole.Print(ex.Message);
                }
            }

            endAction();
        }

        public void FillElectricVehicle()
        {
            while (true)
            {
                try
                {
                    float amountOfEnergy = InputValidation.GetFloat("Enter the amount of energy to add");
                    r_Garage.FillEnergeVehicle(r_Vehicle.LicenseNumber, amountOfEnergy);
                    break;
                } catch (Exception ex)
                {
                    UserConsole.Print(ex.Message);
                }
            }

            endAction();
        }

        public void VehicleInfo()
        {
            UserConsole.Print(r_Garage.VehicleInfo(r_Vehicle.LicenseNumber));
            endAction();
        }

    }
}
