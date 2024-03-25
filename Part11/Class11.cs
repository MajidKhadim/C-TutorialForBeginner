using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part11
{
    internal class Class11
    {
        public static void Work()
        {
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 0:
                    {
                        Console.WriteLine("number is 0");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("number is 1");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("number is 2");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("somthing else");
                        break;
                    }

            }
        }
    }
}
