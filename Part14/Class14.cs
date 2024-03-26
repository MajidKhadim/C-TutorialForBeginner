using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part14
{
    internal class Class14
    {
        public static void Work()
        {
            int userChoice;
           do {
                Console.WriteLine("i will print a number");
                Console.WriteLine("Enter 0 to exit and any number to continue");
                userChoice = int.Parse(Console.ReadLine());
            }
            while (userChoice > 0) ;
        }
    }
}
