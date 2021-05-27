using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public abstract class Vehicle 
    {
        string m_ModelName = string.Empty;
        string m_LicenseNumber = string.Empty;
        float m_RemainingEnergyPrecentage = 0;
        protected Engine m_Engine = null;
        readonly List<Wheel> m_Wheels = new List<Wheel>();
        VehicleGarageInfo m_VehicleGarageInfo = null; 

        public VehicleGarageInfo VehicleInfo
        {
            get { return m_VehicleGarageInfo; }
            set { m_VehicleGarageInfo = value; }
        }

        public string ModelName
        {
            get { return m_ModelName; }

            set { m_ModelName = value; }
        }

        public string LicenseNumber
        {
            get { return m_LicenseNumber; }

            set { m_LicenseNumber = value; }
        }

        public float RemainingEnergyPrecentage
        {
            get
            {
                return m_RemainingEnergyPrecentage;
            }
        }

        public Engine Engine
        {
            get
            {
                return m_Engine;
            }

            set
            {
                m_Engine = value;
            }
        }

        public List<Wheel> Wheels
        {
            get { return m_Wheels; }
        }

        protected void AddWheel(Wheel i_WheelToAdd)
        {
            Wheels.Add(i_WheelToAdd);
        }

        public void SetEnergyPercentage()
        {
            m_RemainingEnergyPrecentage = (m_Engine.CurrentCapacity / m_Engine.MaxCapacity) * 100;
        }

        public override bool Equals(object obj)
        {
            bool equals = false;

            Vehicle toCompareTo = obj as Vehicle;
            if(toCompareTo != null)
            {
                equals = this.LicenseNumber.Equals(toCompareTo.LicenseNumber);
            }

            return equals;
        }

        public static bool operator ==(Vehicle i_FirstVehicle, Vehicle i_SecondVehicle)
        {
            return (i_FirstVehicle.Equals(i_SecondVehicle));
        }

        public static bool operator !=(Vehicle i_FirstVehicle, Vehicle i_SecondVehicle)
        {
            return !(i_FirstVehicle.Equals(i_SecondVehicle));
        }

        public override string ToString()
        {
            string msg;

            msg = string.Format(
@"Model Name: {0},
LicenseNumber: {1},
RemainingEnergyPrecentage: {2}%  
Wheels info:
        Numer of wheels : {3}
        Wheel condition : {4}    
Stage In Garage: {5}
Owner Name: {6}
Owner Phone Number: {7}", m_ModelName, m_LicenseNumber, m_RemainingEnergyPrecentage, m_Wheels.Count,m_Wheels[0], m_VehicleGarageInfo.VehicleCondition, m_VehicleGarageInfo.OwnerName, m_VehicleGarageInfo.OwnerPhoneNumber);
            
            return msg;
        }

    }
}
