using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
    class VehicleAction
    {
        Vehicle m_Vehicle;
        Garage m_Garage;

        public VehicleAction(Vehicle i_Vehicle)
        {
            m_Vehicle = i_Vehicle;
        }

        public void ChangeVehicleStatus()
        {
            VehicleGarageInfo.eVehicleCondition vehicleStatus = (VehicleGarageInfo.eVehicleCondition)InputValidation.GetVehicleCondotion();
            m_Garage.ChangeVehicleCondition(m_Vehicle.LicenseNumber, vehicleStatus);
        }

        public void FillAirWheels()
        {
            m_Garage.FillAirToMax(m_Vehicle.LicenseNumber);
        }

        public void FillFuelVehicle()
        {
            FuelEngine.eFuelType fuelTypeInput = (FuelEngine.eFuelType)InputValidation.GetFuelType();
            float amountOfFuel = InputValidation.GetEnergyAmount();
            m_Garage.FillFuelVehicle(m_Vehicle.LicenseNumber, fuelTypeInput, amountOfFuel);
        }

        public void FillElectricVehicle()
        {
            float amountOfEnergy = InputValidation.GetEnergyAmount();
            m_Garage.FillEnergeVehicle(m_Vehicle.LicenseNumber, amountOfEnergy);
        }

        public void VehicleInfo()
        {
            m_Garage.VehicleInfo(m_Vehicle.LicenseNumber);
        }

    }
}
