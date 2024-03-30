using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part28
{
    internal struct Class28
    {
        private int _data;
        public static void PrintMyName()
        {
            Console.WriteLine("Majid Khadim");
        }
        public static void PrintMyName(int count)
        {
            while (count >= 0)
            {
                Console.WriteLine("Majid Khadim");
                count--;
            }
        }
        public static void PrintMyName(out int count)
        {
            count = 10;
        }
    }
}
