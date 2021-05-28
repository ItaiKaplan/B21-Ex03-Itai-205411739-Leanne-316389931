using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
    internal class GarageAction
    {
        readonly Garage r_Garage;

        internal GarageAction(Garage i_Garage)
        {
            r_Garage = i_Garage;
        }

        internal Garage Garage
        {
            get { return r_Garage; }
        }

        public void AddVehicleToGarage()
        {
            Vehicle vehicle;
            VehicleFactory.eVehicleTypes vehicleType;

            vehicleType = (VehicleFactory.eVehicleTypes)InputValidation.EnumChoiseToInt(typeof(VehicleFactory.eVehicleTypes), UserConsole.ChooseString("vehicle type"));
            vehicle = VehicleFactory.InitVehicle(vehicleType);
            vehicle.ModelName = InputValidation.GetString("\nEnter model Name: ");
            vehicle.LicenseNumber = InputValidation.GetString("\nEnter License number: ");
            vehicle.VehicleInfo = setVehicleInfo();
            setEnergy(vehicle);
            setWheelInfo(vehicle);
            setExtraDetailes(vehicle);
            r_Garage.AddVehicleToGarage(vehicle);
            UserConsole.Print("\nVehicle was secsseful added!");
            endAction();
        }

        private VehicleGarageInfo setVehicleInfo()
        {
            VehicleGarageInfo vehicleGarageInfo;

            while (true) {
                try
                {
                    string ownerName = InputValidation.GetString("\nEnter owner Name: ");
                    string ownerNumber = InputValidation.GetString("\nEntetr owner phone number: ");
                    vehicleGarageInfo = new VehicleGarageInfo(ownerName, ownerNumber);
                    break;
                } catch(Exception ex)
                {
                    UserConsole.Print(ex.Message);
                }
            }

            return vehicleGarageInfo;
        }

        private void setEnergy(Vehicle i_Vehicle)
        {
            if(i_Vehicle.Engine is FuelEngine)
            {
                setFuel(i_Vehicle);
            } 
            else
            {
                setELectric(i_Vehicle);
            }

            i_Vehicle.SetEnergyPercentage();
        }

        private float setFuel(Vehicle i_Vehicle)
        {
            FuelEngine.eFuelType fuelType;
            float fuelAmount = 0;

            while (true)
            {
                try
                {
                    FuelEngine fuelEngine = i_Vehicle.Engine as FuelEngine;
                    UserConsole.Print("\nLets fill up Fuel!");
                    fuelType = (FuelEngine.eFuelType)InputValidation.EnumChoiseToInt(typeof(FuelEngine.eFuelType), UserConsole.ChooseString("fuel type"));
                    fuelAmount = InputValidation.GetFloat("\nEnter amount of fuel you want to fill: ");
                    fuelEngine.FillFuel(fuelType, fuelAmount);
                    break;
                    
                }
                catch (Exception ex)
                {
                    UserConsole.Print(ex.Message);
                }
            }

            return fuelAmount;
        }

        private float setELectric(Vehicle i_Vehicle)
        {
            float energyAmount = 0;

            while (true)
            {
                try
                {
                    ElectricEngine ElectricEngine = i_Vehicle.Engine as ElectricEngine;
                    energyAmount = InputValidation.GetFloat("\nEnter amount of hours you want to fill: ");
                    ElectricEngine.RefillEnergySource(energyAmount);
                    break;
                }
                catch (Exception ex)
                {
                    UserConsole.Print(ex.Message);
                }
            }

            return energyAmount;
        }

        private void setWheelInfo(Vehicle i_Vehicle)
        {
            float airInput;
            string wheelManufacture;

            while (true)
            {
                try
                {
                    wheelManufacture = InputValidation.GetString("\nEnter wheel manufacture: ");
                    airInput = InputValidation.GetFloat("\nEnter how much air you want to add to the wheels: ");
                    foreach (Wheel wheel in i_Vehicle.Wheels)
                    {
                        wheel.InflateWheel(airInput);
                        wheel.ManufacturerName = wheelManufacture;
                    }

                    break;
                }
                catch (Exception ex)
                {
                    UserConsole.Print(ex.Message);
                    break;
                }
            }
        }

        private void setExtraDetailes(Vehicle i_Vehicle)
        {
            if(i_Vehicle is Car)
            {
                setCarInfo(i_Vehicle as Car);
            } 
            else if(i_Vehicle is Motorcycle)
            {
                setMotorcycleInfo(i_Vehicle as Motorcycle);
            }
            else if(i_Vehicle is Truck)
            {
                setTruckInfo(i_Vehicle as Truck);
            }
        }

        private void setCarInfo(Car i_Car)
        {
            while (true)
            {
                try
                {
                    i_Car.Color = (Car.eColor)InputValidation.EnumChoiseToInt(typeof(Car.eColor), UserConsole.ChooseString("car color"));
                    i_Car.NumberOfDoors = (Car.eNumberOfDoors)InputValidation.EnumChoiseToInt(typeof(Car.eNumberOfDoors), UserConsole.ChooseString("number of doors for car"));
                    break;
                }
                catch (Exception ex)
                {
                    UserConsole.Print(ex.Message);
                }
            }
        }


        private void setMotorcycleInfo(Motorcycle i_Motorcycle)
        {
            while (true)
            {
                try
                {
                    i_Motorcycle.LicenseType = (Motorcycle.eLicenseType)InputValidation.EnumChoiseToInt(typeof(Motorcycle.eLicenseType), UserConsole.ChooseString("license type"));
                    i_Motorcycle.EngineVolume = InputValidation.GetPositiveInt("\nEnter Engine volume: ");
                    break;
                }
                catch (Exception ex)
                {
                    UserConsole.Print(ex.Message);
                }
            }
        }

        private void setTruckInfo(Truck i_Truck)
        {
            while (true)
            {
                try
                {
                    i_Truck.ContainsDangerousMaterials = InputValidation.GetBool("\nDoes truck contains dangerous materials? ");
                    i_Truck.MaxCarryWeight = InputValidation.GetFloat("\nEnter max carry weight: ");
                    break;
                }
                catch (Exception ex)
                {
                    UserConsole.Print(ex.Message);
                }
            }
        }

        public void ShowAllVehicles()
        {
            UserConsole.Print("All vehicals in the garage: \n");
            UserConsole.Print(r_Garage.VehicleInGarageToString());
            endAction();
        }

        public void ShowVehiclesWithFilter()
        {
            VehicleGarageInfo.eVehicleCondition vehicleCondition;

            while (true)
            {
                try
                {
                    vehicleCondition = (VehicleGarageInfo.eVehicleCondition)InputValidation.EnumChoiseToInt(typeof(VehicleGarageInfo.eVehicleCondition), UserConsole.ChooseString("vehicle condition"));
                    UserConsole.Print(string.Format("All vehicels in the garage that are {0}", vehicleCondition.ToString()));
                    UserConsole.Print(r_Garage.VehicleInGarageToString(vehicleCondition));
                    break;
                } catch(Exception ex)
                {
                    UserConsole.Print(ex.Message);
                    break;
                }
            }

            endAction();
        }

        private void endAction()
        {
            UserConsole.PrintAndRead("\nEnter any key to go back to the main manu");
            UserConsole.Clear();
            ManuToUser.NextStepMainManu(r_Garage);
        }

    }
}
