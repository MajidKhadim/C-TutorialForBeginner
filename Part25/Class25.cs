using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part25
{
    internal class Class25
    {
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
    //int count;
    //Class25.PrintMyName();
    //        Class25.PrintMyName(5);
    //        Class25.PrintMyName(out count);
    //        Console.WriteLine(count);
}
