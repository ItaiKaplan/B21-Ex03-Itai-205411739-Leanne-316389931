using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
    internal class GarageApp
    {
        readonly Garage r_Garage = new Garage();

        internal void StartGarageApp()
        {
            UserConsole.Print("░W░e░l░c░o░m░e░ ░t░o░ ░t░h░e░ ░G░A░R░A░G░E░\n");
            MenuToUser.NextStepMainManu(r_Garage);
        }
    }
}
