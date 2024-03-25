using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part10
{
    internal class Class10
    {
        public static void Work()
        {
            int number = int.Parse(Console.ReadLine());
            if(number > 10)
            {
                Console.WriteLine("Greater than 10");
            }
            else 
            {
                Console.WriteLine("Less than 10");
            }
            bool IsPass = true;
            if(number > 10 && IsPass)
            {
                Console.WriteLine("Perfect");
            }
        }
    }
}
