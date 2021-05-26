using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.ConsoleUI
{
    class MessegesToUser
    {
        public const string k_WelcomeMsg = "░W░e░l░c░o░m░e░ ░t░o░ ░t░h░e░ ░G░A░R░A░G░E░";
        public const string k_MainManu =
@"Please enter the number of option you would like to do:
1. Add a new vehicle to the garage
2. Show All Vehicles in the garage
3. Show Vehicles in garage with filter 
4. Specipic vehicle actions
5. Exit";
        public const string k_VehicleManu =
@"Please enter the number of option you would like to do:
1. Change vhicle status in garage
2. Fill air in wheels to maximum 
2. Fill up fuel in a fuel car
3. Fill up energy in an electric car
4. Vehicle info
5. Back to main manu";

        public const string k_InvalidInput = "Input is not valid, please enter again";
        public const string k_EnterLicenseNumer = "Pleanse enter Licence Number";

        public static string EnumToString(Type i_EnumType)
        {
            StringBuilder enumToString = new StringBuilder("");
            int counter = 1;

            enumToString.Append(counter + ". ");
            foreach (Enum enumValue in Enum.GetValues(i_EnumType))
            {
                enumToString.Append(counter + ". " + enumValue.ToString() + "\n");
                counter++;
            }

            return enumToString.ToString();
        }
    }
}
