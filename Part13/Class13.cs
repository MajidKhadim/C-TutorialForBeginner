using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part13
{
    internal class Class13
    {
        public static void Work()
        {
        //While loops;
            Console.WriteLine("Enter a number greater than 0");
        again:
            int TillNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            if( TillNumber <= 0 ) 
            {
                Console.WriteLine("Please enter a number greater than 0");
                goto again;
            }
            while(counter<= TillNumber)
            {
                Console.WriteLine(counter);
                counter++;
            }
        }
    }
}
