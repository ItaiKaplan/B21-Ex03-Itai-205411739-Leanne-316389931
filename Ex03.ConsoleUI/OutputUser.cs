using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.ConsoleUI
{
    public static class OutputUser
    {
        public static void Print(string i_Msg)
        {
            Console.WriteLine(i_Msg);
        }

        public static void Clear()
        {
            Console.Clear();
        }

        public static void ClearAndPring(string i_Msg)
        {
            Clear();
            Print(i_Msg);
        }
    }
}
