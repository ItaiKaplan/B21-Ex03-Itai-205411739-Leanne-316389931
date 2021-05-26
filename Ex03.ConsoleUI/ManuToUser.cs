using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.ConsoleUI
{
    class ManuToUser
    {
        enum eMainManu
        {
            AddVehicleToGarage = 1,
            ShowAllVehicles = 2,
            ShowVehiclesFilter = 3,
            VehicleOption = 4,
        }

        enum eVehicleManu
        {
            ChangeVehicleStatus = 1,
            FillAirWheels = 2,
            FillFuelVehicle = 3,
            FillElectricVehicle = 4,
            VehicleInfo = 5
        }

        public void NextStep(int i_Input)
        {

        }
    }
}
