using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class ValueOutOfRangeException : Exception
    {
        float m_MaxValue = 0;
        float m_MinValue = 0;

        public ValueOutOfRangeException(float i_MinValue, float i_MaxValue)
            : base(string.Format("Input is out of range, Range is {0} to {1}", i_MinValue, i_MaxValue))
        {
            m_MaxValue = i_MaxValue;
            m_MinValue = i_MinValue;
            
        }
    }
}
