using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part5
{
    internal class Class5
    {
        string Name = "Majid Khadim"; // = operator
        static int ans = 34 + 56; //arithmetic
        static int mod = 56 % 5;
        public static void Work()
        {
            Console.WriteLine(ans == 45); //comparison 
            Console.WriteLine(ans == 90 && mod == 2); // conditional
            Console.WriteLine(ans == 90? "True":"False");
        }
    }
}
