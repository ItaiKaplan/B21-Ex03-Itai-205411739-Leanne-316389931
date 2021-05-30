using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
    internal class GarageApp
    {
        private readonly Garage r_Garage = new Garage();

        internal void StartGarageApp()
        {
            UserConsole.Print("\n\t\t\t░W░e░l░c░o░m░e░ ░t░o░ ░t░h░e░ ░G░A░R░A░G░E░\n");
            MenuToUser.NextStepMainMenu(r_Garage);
        }
    }
}
