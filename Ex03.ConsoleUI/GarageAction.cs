using System;
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
            VehicleCreater.eVehicleTypes vehicleType;
            while (true)
            {
                try
                {
                    vehicleType = (VehicleCreater.eVehicleTypes)InputValidation.EnumChoiseToInt(typeof(VehicleCreater.eVehicleTypes),
                        UserConsole.ChooseString("vehicle type"));
                    vehicle = VehicleCreater.InitVehicle(vehicleType);
                    vehicle.LicenseNumber = InputValidation.GetString("\nEnter License number: ");
                    vehicle.ModelName = InputValidation.GetString("\nEnter model Name: ");
                    r_Garage.AddVehicleToGarage(vehicle);
                    break;
                }
                catch (Exception ex)
                {
                    UserConsole.ExceptionOutput(ex);
                }
            }
            vehicle.VehicleInfo = setVehicleInfo();
            setEnergy(vehicle);
            UserConsole.SleepAndClear();
            setWheelInfo(vehicle);
            UserConsole.Print("\n");
            setExtraDeatails(vehicle);
            UserConsole.Print("\nVehicle was added successfully!");
            endAction();

        }

        private VehicleGarageInfo setVehicleInfo()
        {
            VehicleGarageInfo vehicleGarageInfo;

            while (true) {
                try
                {
                    string ownerName = InputValidation.GetString("\nEnter owner Name: ");
                    string ownerNumber = InputValidation.GetStringNumber("\nEnter owner phone number: ");
                    vehicleGarageInfo = new VehicleGarageInfo(ownerName, ownerNumber);
                    break;
                }
                catch(Exception ex)
                {
                    UserConsole.ExceptionOutput(ex);
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
                setElectric(i_Vehicle);
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
                    UserConsole.ExceptionOutput(ex);
                }
            }

            return fuelAmount;
        }

        private float setElectric(Vehicle i_Vehicle)
        {
            float energyAmount = 0;

            while (true)
            {
                try
                {
                    ElectricEngine ElectricEngine = i_Vehicle.Engine as ElectricEngine;
                    UserConsole.SleepAndClear();
                    energyAmount = InputValidation.GetFloat("\nEnter amount of minutes of energy you want to fill: ");
                    ElectricEngine.RefillEnergySource(energyAmount);
                    break;
                }
                catch (Exception ex)
                {
                    UserConsole.ExceptionOutput(ex);
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
                    UserConsole.ExceptionOutput(ex);
                }
            }
        }

        private void setExtraDeatails(Vehicle i_Vehicle)
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
                    UserConsole.ExceptionOutput(ex);
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
                    UserConsole.ExceptionOutput(ex);
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
                    UserConsole.ExceptionOutput(ex);
                }
            }
        }

        public void ShowAllVehicles()
        {
            try
            {
                UserConsole.Print("All vehicals in the garage: \n");
                UserConsole.Print(r_Garage.VehicleInGarageToString());
            } 
            catch(Exception ex)
            {
                UserConsole.ExceptionOutput(ex);
            } 
            finally
            {
                UserConsole.PrintAndRead("Press any key to go back to vehicle menu");
                endAction();
            }
        }

        public void ShowVehiclesWithFilter()
        {
            VehicleGarageInfo.eVehicleCondition vehicleCondition;

            while (true)
            {
                try
                {
                    vehicleCondition = (VehicleGarageInfo.eVehicleCondition)InputValidation.EnumChoiseToInt(typeof(VehicleGarageInfo.eVehicleCondition), UserConsole.ChooseString("vehicle condition"));
                    UserConsole.Print(string.Format("All vehicles in the garage that are {0}:", vehicleCondition.ToString()));

                    UserConsole.Print(r_Garage.VehicleInGarageToString(vehicleCondition));
                    break;
                } 
                catch(Exception ex)
                {
                    UserConsole.ExceptionOutput(ex);
                }
                finally
                {
                    UserConsole.PrintAndRead("Press any key to go back to vehicle menu");
                    endAction();
                }
            }


            endAction();
        }

        private void endAction()
        {
            UserConsole.SleepAndClear();
            MenuToUser.NextStepMainMenu(r_Garage);
        }

    }
}
