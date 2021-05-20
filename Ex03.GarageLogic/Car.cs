using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class Car : Vehicle
    {
        enum eColor
        {
            Red,
            Silver,
            White,
            Black
        }
        enum eNumberOfDoors
        {
            2,
            3,
            4,
            5
        }
        eColor m_Color;
        eNumberOfDoors m_NumberOfDoors;
    }
}
