using System;
using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
    public static class InputValidation
    {
        public static float GetFloat(string i_Msg)
        {
            string stringInput;
            float o_InputNumber = 0;
            bool isNumber;

            UserConsole.Print(i_Msg);
            stringInput = UserConsole.Read();
            isNumber = float.TryParse(stringInput, out o_InputNumber);
            if (!isNumber)
            {
                throw new FormatException("The input is not a number");
            }
            else if (o_InputNumber < 0)
            {
                throw new Exception("The input is not a positive number");
            }
            else
            {
                return o_InputNumber;
            }
        }

        public static int GetPositiveInt(string i_Msg)
        {
            string stringInput;

            UserConsole.Print(i_Msg);
            stringInput = UserConsole.Read();
            return parseInt(stringInput);      
        }

        public static string GetStringNumber(string i_Msg)
        {
            string stringInput;
            bool isNumber;
            int number = 0;

            UserConsole.Print(i_Msg);
            stringInput = UserConsole.Read();
            isNumber = int.TryParse(stringInput, out number);
            if(!isNumber || number < 0)
            {
                throw new ArgumentException("The input is not a number");
            }
            return stringInput;
        }

        public static int GetInt(string i_Msg, int i_Min, int i_Max)
        {
            int userChoise;

            userChoise = GetPositiveInt(i_Msg);
            if((userChoise > i_Max) || (userChoise < i_Min))
            {
                throw new ValueOutOfRangeException((float)i_Min, (float)i_Max);
            }

            return userChoise;
        }

        public static string GetString(string i_Msg)
        {
            string stringInput;

            UserConsole.Print(i_Msg);
            stringInput = UserConsole.Read();
            if (stringInput.Length == 0)
            {
                throw new Exception("Please enter a string");
            }
            else
            { 
                return stringInput;
            }
                
        }

        public static bool GetBool(String i_Msg)
        {
            string inputString;
            bool result = true;

            UserConsole.Print(i_Msg);
            UserConsole.Print("Enter 0 for no, 1 for yes.");
            inputString = UserConsole.Read();
            if(!inputString.Equals("1") && !inputString.Equals("0"))
            {
                throw new Exception("You didnt enter 0 or 1");
            } 
            else if(inputString.Equals("0"))
            {
                result = false;
            }

            return result;
        }

        private static int parseInt(string i_Input)
        {
            int o_InputNumber = 0;
            bool isNumber;

            isNumber = int.TryParse(i_Input, out o_InputNumber);
            if (!isNumber)
            {
                throw new FormatException("The input is not a number");
            }
            else if (o_InputNumber < 0)
            {
                throw new Exception("The input is not a positive number");
            }
            else
            {
                return o_InputNumber;
            }
        }

        public static int EnumChoiseToInt(Type i_EnumType, String i_msg)
        {
            string userInput;
            string msg;
            int userChoise;
            int minChoise = 1;
            int maxChoise;

            UserConsole.SleepAndClear();
            UserConsole.Print(i_msg);
            UserConsole.Print(UserConsole.EnumToString(i_EnumType));
            userInput = UserConsole.Read();
            userChoise = parseInt(userInput);
            maxChoise = Enum.GetNames(i_EnumType).Length;
            if((userChoise < minChoise) || (userChoise > maxChoise))
            {
                throw new ValueOutOfRangeException((float)minChoise, (float)maxChoise);
            }

            msg = string.Format(@"You choose {0}", userChoise);
            UserConsole.Print(msg);
            return userChoise;
        }
    }
}
