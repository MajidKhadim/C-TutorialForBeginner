using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part93
{
    internal class Class93
    {
        static int Total = 0;
        public static void MainFunction()
        {
            Thread T1 = new Thread(Class93.Fun1);
            Thread T2 = new Thread(Class93.Fun1);
            Thread T3 = new Thread(Class93.Fun1);
            T1.Start();
            T2.Start();
            T3.Start();

            T1.Join();
            T2.Join();
            T3.Join();
            Console.WriteLine($"Total = " + Total);
        }

        public static void Fun1()
        {
            for(int i = 0; i < 1000000; i++) 
            {
                Interlocked.Increment(ref Total);
            }
        }
       
    }

}
