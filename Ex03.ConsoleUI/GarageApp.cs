using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
    internal class GarageApp
    {
        readonly Garage r_Garage = new Garage();

        internal void StartGarageApp()
        {
            UserConsole.Print("░W░e░l░c░o░m░e░ ░t░o░ ░t░h░e░ ░G░A░R░A░G░E░\n");
            ManuToUser.NextStepMainManu(r_Garage);
        }
    }
}
