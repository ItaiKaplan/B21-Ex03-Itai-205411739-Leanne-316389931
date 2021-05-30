using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public abstract class Vehicle 
    {
        private string m_ModelName = string.Empty;
        private string m_LicenseNumber = string.Empty;
        private float m_RemainingEnergyPrecentage = 0;
        private protected Engine m_Engine = null;
        private readonly List<Wheel> r_Wheels = new List<Wheel>();
        private VehicleGarageInfo m_VehicleGarageInfo = null; 

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
            get { return m_RemainingEnergyPrecentage; }
        }

        public Engine Engine
        {
            get { return m_Engine; }
            set { m_Engine = value; }
        }

        public List<Wheel> Wheels
        {
            get { return r_Wheels; }
        }

        protected void AddWheel(Wheel i_WheelToAdd)
        {
            Wheels.Add(i_WheelToAdd);
        }

        public void SetEnergyPercentage()
        {
            m_RemainingEnergyPrecentage = (m_Engine.CurrentCapacity / m_Engine.MaxCapacity) * 100;
        }

        public override string ToString()
        {
            string msg;

            msg = string.Format(
@"Model Name: {0}
LicenseNumber: {1}
RemainingEnergyPrecentage: {2}%  
Wheels info:
        Numer of wheels : {3}
        {4}    
Stage In Garage: {5}
Owner Name: {6}
Owner Phone Number: {7}", 
m_ModelName, 
m_LicenseNumber, 
m_RemainingEnergyPrecentage, 
r_Wheels.Count,
r_Wheels[0], 
m_VehicleGarageInfo.VehicleCondition, 
m_VehicleGarageInfo.OwnerName, 
m_VehicleGarageInfo.OwnerPhoneNumber);
            
            return msg;
        }

    }
}
