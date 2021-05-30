using System;
using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
    public class VehicleAction
    {
        private readonly Vehicle r_Vehicle;
        private readonly Garage r_Garage;

        public VehicleAction(Vehicle i_Vehicle, Garage i_Garage)
        {
            r_Vehicle = i_Vehicle;
            r_Garage = i_Garage;
        }

        private void endAction()
        {
            UserConsole.SleepAndClear();
            MenuToUser.NextStepVehicleMenu(r_Garage, r_Vehicle);
        }
        
        public void ChangeVehicleStatus()
        {
            while(true)
            {
                try
                {
                    VehicleGarageInfo.eVehicleCondition vehicleStatus = (VehicleGarageInfo.eVehicleCondition)InputValidation.EnumChoiseToInt(typeof(VehicleGarageInfo.eVehicleCondition), UserConsole.ChooseString("vehicle condition"));
                    r_Garage.ChangeVehicleCondition(r_Vehicle.LicenseNumber, vehicleStatus);
                    break;
                }
                catch(Exception ex)
                {
                    UserConsole.ExceptionOutput(ex);
                }
            }

            endAction();
        }

        public void FillAirWheels()
        {
            while(true)
            {
                try
                {
                    r_Garage.FillAirToMax(r_Vehicle.LicenseNumber);
                    break;
                }
                catch(Exception ex)
                {
                    UserConsole.ExceptionOutput(ex);
                }
            }

            UserConsole.Print("Filling air finished!");
            endAction();
        }

        public void FillFuelVehicle()
        {
            while(true)
            {
                try
                {
                    FuelEngine.eFuelType fuelTypeInput = (FuelEngine.eFuelType)InputValidation.EnumChoiseToInt(typeof(FuelEngine.eFuelType), UserConsole.ChooseString("fuel type"));
                    float amountOfFuel = InputValidation.GetFloat("Enter the amount of fuel to fill");
                    r_Garage.FillFuelVehicle(r_Vehicle.LicenseNumber, fuelTypeInput, amountOfFuel);
                    break;
                }
                catch(Exception ex)
                {
                    UserConsole.ExceptionOutput(ex);
                    if(ex.Message.Contains("not on fuel!"))
                    {
                        break;
                    }
                }
            }

            endAction();
        }

        public void FillElectricVehicle()
        {
            while(true)
            {
                try
                {
                    float amountOfEnergy = InputValidation.GetFloat("Enter the amount of minutes of energy to add");
                    r_Garage.FillEnergeVehicle(r_Vehicle.LicenseNumber, amountOfEnergy);
                    break;
                } 
                catch(Exception ex)
                {
                    UserConsole.ExceptionOutput(ex);
                    if(ex.Message.Contains("on fuel"))
                    {
                        break;
                    }
                }
            }

            endAction();
        }

        public void VehicleInfo()
        {
            UserConsole.Print(r_Garage.VehicleInfo(r_Vehicle.LicenseNumber));
            UserConsole.PrintAndRead("\nPress any key to go back to vehicle menu");
            endAction();
        }
    }
}
