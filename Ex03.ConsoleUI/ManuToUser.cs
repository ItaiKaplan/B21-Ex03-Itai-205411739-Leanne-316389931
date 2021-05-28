using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
    public class ManuToUser
    {
        enum eMainManu
        {
            AddVehicleToGarage = 1,
            ShowAllVehicles = 2,
            ShowVehiclesWithFilter = 3,
            VehicleActions = 4,
            Exit = 5
        }

        enum eVehicleMenu
        {
            ChangeVehicleStatus = 1,
            FillAirWheels = 2,
            FillFuelVehicle = 3,
            FillElectricVehicle = 4,
            VehicleInfo = 5,
            Back = 6
        }

        public static void NextStepMainManu(Garage i_Garage)
        {
            UserConsole outputUser = new UserConsole();
            GarageAction garageAction = new GarageAction(i_Garage);
            int userChoise; 

            while (true)
            {
                try
                {
                    UserConsole.Print(UserConsole.k_MainManu);
                    userChoise = InputValidation.GetInt("", 1, 5);
                    break;
                } catch(Exception ex)
                {
                    UserConsole.Print(ex.Message);
                }
            }

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
                    ManuToUser.NextStepVehicleManu(i_Garage);
                    break;
                case 5:
                    System.Environment.Exit(0);
                    break;
            }

        }

        public static void NextStepVehicleManu(Garage i_Garage)
        {
            UserConsole outputUser = new UserConsole();
            int userChoise;
            string licenseNumber;
            Vehicle vehicle;

            while (true)
            {
                licenseNumber = InputValidation.GetString("Enter License number");
                try
                {
                    UserConsole.Print(UserConsole.k_VehicleManu);
                    userChoise = InputValidation.GetInt("", 1, 6);
                    vehicle = i_Garage.GetVehicle(licenseNumber);
                    break;
                }
                catch (Exception ex)
                {
                    UserConsole.Print(ex.Message);
                }
            }

            VehicleAction vehicleAction = new VehicleAction(vehicle, i_Garage);
            switch (userChoise)
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
                    NextStepMainManu(i_Garage);
                    break;
            }
        }
    }
}
