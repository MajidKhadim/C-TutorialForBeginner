using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part96
{
    internal class Class96
    {
        public static void MainFunction()
        {
            Console.WriteLine("Main Started");
            Thread t1 = new Thread(Class96.Fun1);
            t1.Start();
            Thread t2 = new Thread(Class96.Fun2);
            t2.Start();
            t1.Join();
            Console.WriteLine("Fun1 completed");
            t2.Join();
            Console.WriteLine("Fun2 completed");
            Console.WriteLine("Main Completed");
        }

        public static void Fun1()
        {
            Console.WriteLine("F1");
        }
        public static void Fun2()
        {
            Console.WriteLine("F2");
        }
    }

}
