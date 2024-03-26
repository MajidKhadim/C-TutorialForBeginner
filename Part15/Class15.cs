using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part15
{
    internal class Class15
    {
        public static void Work()
        {
            int[] arr = { 2, 3, 4, 5, 6, 7, 8, 9, 10, };
            foreach (int i in arr)
            {
                if(i == 8)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
