using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part88
{
    internal class Class88
    {
        public static void MainFunction()
        {
            Thread t1 = new Thread(new ThreadStart(Number.PrintNumbers));
            t1.Start();
        }
    }
    class Number
    {
        public static void PrintNumbers()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
