using System;
using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
    public class MenuToUser
    {
        private enum eMainMenu
        {
            AddVehicleToGarage = 1,
            ShowAllVehicles = 2,
            ShowVehiclesWithFilter = 3,
            VehicleActions = 4,
            Exit = 5
        }

        private enum eVehicleMenu
        {
            ChangeVehicleStatus = 1,
            FillAirWheels = 2,
            FillFuelVehicle = 3,
            FillElectricVehicle = 4,
            VehicleInfo = 5,
            Back = 6
        }

        public static void NextStepMainMenu(Garage i_Garage)
        {
            UserConsole outputUser = new UserConsole();
            GarageAction garageAction = new GarageAction(i_Garage);
            int userChoise;

            UserConsole.MainMenu();
            while(true)
            {
                try
                {
                    userChoise = InputValidation.GetInt(string.Empty, 1, 5);
                    break;
                } 
                catch(Exception ex)
                {
                    UserConsole.Print(ex.Message);
                }
            }

            UserConsole.SleepAndClear();
            switch(userChoise)
            {
                case 1:
                    garageAction.AddVehicleToGarage();
                    break;
                case 2:
                    garageAction.ShowAllVehicles();
                    break;
                case 3:
                    garageAction.ShowVehiclesWithFilter();
                    break;
                case 4:
                    NextStepVehicleMenu(i_Garage, null);
                    break;
                case 5:
                    System.Environment.Exit(0);
                    break;
            }
        }

        public static void NextStepVehicleMenu(Garage i_Garage, Vehicle i_Vehicle)
        {
            UserConsole outputUser = new UserConsole();
            int userChoise;
            string licenseNumber;
            Vehicle vehicle;
            VehicleAction vehicleAction = null;
            bool inputAnswer = true;

            if(i_Vehicle != null)
            {
                while(true)
                {
                    try
                    {
                        inputAnswer = InputValidation.GetBool("Do you want to switch vehicle?");
                        break;
                    }
                    catch(Exception ex)
                    {
                        UserConsole.ExceptionOutput(ex);
                    }
                }

                if(!inputAnswer)
                {
                    vehicleAction = new VehicleAction(i_Vehicle, i_Garage);
                }
            }

            if(inputAnswer)
            {
                while(true)
                {
                    try
                    {
                        licenseNumber = InputValidation.GetString("Enter License number");
                        vehicle = i_Garage.GetVehicle(licenseNumber);
                        break;
                    }
                    catch(Exception ex)
                    {
                        UserConsole.ExceptionOutput(ex);
                    }
                }

                vehicleAction = new VehicleAction(vehicle, i_Garage);
            }

            while(true)
            {
                try
                {
                    UserConsole.VehicleMenu();
                    userChoise = InputValidation.GetInt(string.Empty, 1, 6);
                    break;
                }
                catch(Exception ex)
                {
                    UserConsole.ExceptionOutput(ex);
                }
            }

            UserConsole.SleepAndClear();
            switch(userChoise)
            {
                case 1:
                    vehicleAction.ChangeVehicleStatus();
                    break;
                case 2:
                    vehicleAction.FillAirWheels();
                    break;
                case 3:
                    vehicleAction.FillFuelVehicle();
                    break;
                case 4:
                    vehicleAction.FillElectricVehicle();
                    break;
                case 5:
                    vehicleAction.VehicleInfo();
                    break;
                case 6:
                    NextStepMainMenu(i_Garage);
                    break;
            }
        }
    }
}
