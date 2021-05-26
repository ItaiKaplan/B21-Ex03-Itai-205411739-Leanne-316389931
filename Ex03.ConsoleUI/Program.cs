using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.ConsoleUI
{
    class Program
    {
        public static void Main()
        {
            int input = 0;
            InputOutputIser.PrintMsg(InputOutputIser.k_WelcomeMsg);
            InputOutputIser.PrintMsg(InputOutputIser.k_MainManu);
            input = ConsoleInput.MainManuInput();
            GarageActions.Go(input);
            

        }
    }
}
