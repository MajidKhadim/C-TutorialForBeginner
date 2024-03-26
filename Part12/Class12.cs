using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part12
{
    internal class Class12
    {
        public static void Work()
        {
            int sum = 0;
            again:
            Console.WriteLine("Enter a number to add in sum (10,20,30)");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 10:
                    {
                        sum += 10;
                        break;
                    }
                case 20:
                    {
                        sum += 20;
                        break;
                    }
                case 30:
                    {
                        sum += 30;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Please Enter a number like (10,20,30)");
                        goto again;
                    }
            }
            Console.WriteLine("Want to add more numbers : yes/no");
            choice:
            string userChoice = Console.ReadLine();
            switch (userChoice.ToLower())
            {
                case "yes":
                    {
                        goto again;
                    }
                case "no":
                    {
                        break;
                    }
                default:
                    goto choice;
            }

            Console.WriteLine($"Your Sum is {sum}");
        }
    }
}
