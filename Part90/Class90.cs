using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part90
{
    internal class Class90
    {
        public static void MainFunction()
        {
            Console.WriteLine("Enter a number : ");
            int target = Convert.ToInt32(Console.ReadLine());
            Number number = new Number(target);
            Thread t1 = new Thread(number.PrintNumbers);
            t1.Start();

        }
    }
    class Number
    {
        private int _target;

        public Number(int target)
        {
            _target = target;
        }
        public void PrintNumbers()
        {
            
                for (int i = 0; i < _target; i++)
                {
                    Console.WriteLine(i);
                }
        }
    }
}
