using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class VehicleGarageInfo
    {
        public enum eVehicleCondition
        {
            InProgress = 1,
            Fixed = 2,
            Paid = 3
        }

        string m_OwnerName = string.Empty;
        string m_OwnerPhoneNumber = string.Empty;
        eVehicleCondition m_VehicleCondition = eVehicleCondition.InProgress;

        public VehicleGarageInfo(string i_OwnerName, string i_OwnerPhoneNumber)
        {
            m_OwnerName = i_OwnerName;
            m_OwnerPhoneNumber = i_OwnerPhoneNumber;
        }

        public string OwnerName
        {
            get { return m_OwnerName; }
            set { m_OwnerName = value; }
        }

        public string OwnerPhoneNumber
        {
            get { return m_OwnerPhoneNumber; }
            set { m_OwnerPhoneNumber = value; }
        }

        public eVehicleCondition VehicleCondition
        {
            get { return m_VehicleCondition; }
            set { m_VehicleCondition = value; }
        }

    }
}
