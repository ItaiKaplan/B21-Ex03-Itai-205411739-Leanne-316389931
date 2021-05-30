using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Garage
    {
        readonly Dictionary<string, Vehicle> r_VehiclesInGarage = new Dictionary<string, Vehicle>();

        public void AddVehicleToGarage(Vehicle i_Vehicle)
        {
            if(r_VehiclesInGarage.ContainsKey(i_Vehicle.LicenseNumber))
            {
                r_VehiclesInGarage[i_Vehicle.LicenseNumber].VehicleInfo.VehicleCondition = VehicleGarageInfo.eVehicleCondition.InProgress;
                throw new Exception("This vehicle is already in the garage, status changed to 'In progress' ");
            }
            else
            {
                r_VehiclesInGarage.Add(i_Vehicle.LicenseNumber, i_Vehicle);
            }
        }

        public string VehicleInGarageToString(VehicleGarageInfo.eVehicleCondition i_VehicleCondition)
        {
            StringBuilder licensNumberList = new StringBuilder("");
            bool conditionExistsInGarage = false;

            if (r_VehiclesInGarage.Count != 0)
            {
                foreach (Vehicle vehicle in r_VehiclesInGarage.Values)
                {
                    if (vehicle.VehicleInfo.VehicleCondition == i_VehicleCondition)
                    {
                        licensNumberList.Append(vehicle.LicenseNumber + "\n");
                        conditionExistsInGarage = true;
                    }
                }
            }
            else
            {
                throw new Exception("No vehicles in garage");
            }

            if(!conditionExistsInGarage)
            {
                licensNumberList.Append("No vehicle with the condition specified in the garage\n");
            }

            return licensNumberList.ToString();
        }

        public string VehicleInGarageToString()
        {
            StringBuilder licensNumberList = new StringBuilder("");

            if (r_VehiclesInGarage.Count != 0) {
                foreach (Vehicle vehicle in r_VehiclesInGarage.Values)
                {
                    licensNumberList.Append(vehicle.LicenseNumber + "\n");
                }
            }
            else
            {
                throw new Exception("No vehicles in garage");
            }

            return licensNumberList.ToString();
        }

        public void ChangeVehicleCondition(string i_LicenseNumber, VehicleGarageInfo.eVehicleCondition i_VehicleConditionToChangeTo)
        {
            checkIfVehicleInGarage(i_LicenseNumber);
            r_VehiclesInGarage[i_LicenseNumber].VehicleInfo.VehicleCondition = i_VehicleConditionToChangeTo;
        }

        public void FillAirToMax(string i_LicenseNumber)
        {
            checkIfVehicleInGarage(i_LicenseNumber);
            foreach(Wheel wheel in r_VehiclesInGarage[i_LicenseNumber].Wheels)
            {
                wheel.FillAirToMax();
            }
        }

        public void FillFuelVehicle(string i_LicenseNumber, FuelEngine.eFuelType i_FuelType, float i_AmountToFill)
        {
            checkIfVehicleInGarage(i_LicenseNumber);
            FuelEngine fuelEngine = r_VehiclesInGarage[i_LicenseNumber].Engine as FuelEngine;
            if (fuelEngine != null)
            {
                if (fuelEngine.FuelType != i_FuelType)
                {
                    throw new ArgumentException("Fuel Type is not a match");
                }

                fuelEngine.FillFuel(i_FuelType, i_AmountToFill);
                r_VehiclesInGarage[i_LicenseNumber].SetEnergyPercentage();
            }
            else
            {
                throw new ArgumentException(string.Format("vehicle {0} is not on fuel!", i_LicenseNumber));
            } 
        }

        public void FillEnergeVehicle(string i_LicenseNumber, float i_AmountToFillInMinutes)
        {
            checkIfVehicleInGarage(i_LicenseNumber);
            checkIfElectriclEngine(i_LicenseNumber);
            r_VehiclesInGarage[i_LicenseNumber].Engine.RefillEnergySource(i_AmountToFillInMinutes / 60);
            r_VehiclesInGarage[i_LicenseNumber].SetEnergyPercentage();
        }

        public string VehicleInfo(string i_LicenseNumber)
        {
            checkIfVehicleInGarage(i_LicenseNumber);

            return r_VehiclesInGarage[i_LicenseNumber].ToString();
        }

        private void checkIfVehicleInGarage(string i_LicenseNumber)
        {
            if (!r_VehiclesInGarage.ContainsKey(i_LicenseNumber))
            {
                throw new ArgumentException(string.Format("No vehicle with license Number {0} in the garage", i_LicenseNumber));
            }
        }

        private void checkIfElectriclEngine(string i_LicenseNumber)
        {
            if (!(r_VehiclesInGarage[i_LicenseNumber].Engine is ElectricEngine))
            {
                throw new ArgumentException(string.Format("vehicle {0} is on fuel and not on energy!", i_LicenseNumber));
            }
        }

        public Vehicle GetVehicle(string i_LicenseNumber)
        {
            checkIfVehicleInGarage(i_LicenseNumber);

            return r_VehiclesInGarage[i_LicenseNumber];
        }
    }
}

