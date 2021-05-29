using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Truck : Vehicle
    {
        const int k_NumberOfWheels = 16;
        const int k_MaxWheelPressure = 26;
        const FuelEngine.eFuelType k_FuelType = FuelEngine.eFuelType.Soler;
        const float k_FuelMaxCapacityTank = 120;
        bool m_ContainsDangerousMaterials;
        float m_MaxCarryWeight;

        public Truck()
            : base()
        {
            this.Engine = new FuelEngine(k_FuelType, k_FuelMaxCapacityTank);
            for(int i = 0; i < k_NumberOfWheels; i++)
            {
                this.AddWheel(new Wheel(k_MaxWheelPressure));
            }
        }

        public bool ContainsDangerousMaterials
        {
            get { return m_ContainsDangerousMaterials; }
            set { m_ContainsDangerousMaterials = value; }
        }

        public float MaxCarryWeight
        {
            get { return m_MaxCarryWeight; }
            set { m_MaxCarryWeight = value; }
        }

        public override string ToString()
        {
            string msg;

            msg = string.Format(
@"This Vehicle is: Fuel Truck
{0}
Fuel Type: {1}
Contains Dangerous Materials: {2}
MaxCarryWeight: {3}", base.ToString(), k_FuelType, m_ContainsDangerousMaterials, m_MaxCarryWeight);

            return msg;
        }
    }
}
