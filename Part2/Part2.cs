using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part2
{
    internal class Part
    {
        public static void Work()
        {
            Console.WriteLine("Please Enter Your Name");
            string Name = Console.ReadLine();
            Console.WriteLine("Your Name is "+Name);
            Console.WriteLine($"Your Name is {Name}");
            Console.WriteLine("Your Name is {0}",Name);
        }
    }
}
