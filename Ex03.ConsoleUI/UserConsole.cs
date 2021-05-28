using System;
using System.Text;

namespace Ex03.ConsoleUI
{
    public class UserConsole
    {
        public static string EnumToString(Type i_EnumType)
        {
            StringBuilder enumToString = new StringBuilder("");
            int counter = 1;

            foreach (Enum enumValue in Enum.GetValues(i_EnumType))
            {
                enumToString.Append(counter + ". " + enumValue.ToString() + "\n");
                counter++;
            }

            return enumToString.ToString();
        }

        public static void Print(string i_Msg)
        {
            Console.WriteLine(i_Msg);
        }

        public static string Read()
        {
            return Console.ReadLine();
        }

        public static void Clear()
        {
            Console.Clear();
        }

        public static void ClearAndPrint(string i_Msg)
        {
            Clear();
            Print(i_Msg);
        }

        public static string ChooseString(string i_Msg)
        {
            return string.Format("Your choises for {0} are:", i_Msg);
        }

        public static void PrintAndRead(string i_msg)
        {
            Print(i_msg);
            Read();
        }

        public static void MainManu()
        {
            string msg = string.Format(@"
Please enter the number of the operation you would like to preform:
1. Add a new vehicle to the garage
2. Show All Vehicles in the garage
3. Show Vehicles in garage with filter 
4. Specific vehicle actions
5. Exit");
            Print(msg);
        }

        public static void VehicleManu()
        {
            string msg = string.Format(@"
Please enter the number of the operation you would like to preform:
1. Change vehicle status 
2. Fill air in wheels  
3. Fill up fuel (Fuel car only)
4. Fill up energy (Electric car only)
5. Vehicle info
6. Back to main manu");
            Print(msg);
        }
    }
}
