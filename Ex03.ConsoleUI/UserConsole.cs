﻿using System;
using System.Text;
using System.Threading;

namespace Ex03.ConsoleUI
{
    public class UserConsole
    {
        public static string EnumToString(Type i_EnumType)
        {
            StringBuilder enumToString = new StringBuilder(string.Empty);
            int counter = 1;

            foreach(Enum enumValue in Enum.GetValues(i_EnumType))
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

        public static void MainMenu()
        {
            string msg = string.Format(@"
M A I N    M E N U :

Please enter the number of the operation you would like to preform:
1. Add a new vehicle to the garage
2. Show All Vehicles in the garage
3. Show Vehicles in garage with filter 
4. Specific vehicle actions
5. Exit");
            Print(msg);
        }

        public static void VehicleMenu()
        {
            string msg = string.Format(@"
V E H I C L E    M E N U :

Please enter the number of the operation you would like to preform:
1. Change vehicle status 
2. Fill air in wheels  
3. Fill up fuel (Fuel car only)
4. Fill up energy (Electric car only)
5. Vehicle info
6. Back to main menu");
            Print(msg);
        }

        public static void ExceptionOutput(Exception i_Exception)
        {
            ClearAndPrint(i_Exception.Message);
        }

        public static void SleepAndClear()
        {
            Thread.Sleep(1000);
            Clear();
        }
    }
}
