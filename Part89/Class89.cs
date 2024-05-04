using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part89
{
    internal class Class89
    {
        public static void MainFunction()
        {
            Console.WriteLine("Enter a number : ");
            object target=Console.ReadLine();
            Number number = new Number();
            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(number.PrintNumbers);
            Thread t1 = new Thread(parameterizedThreadStart);
            t1.Start(target);

        }
    }
    class Number
    {
        public void PrintNumbers(object target)
        {
            int number = 0;
            if (int.TryParse(target.ToString(), out number))
            {
                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
