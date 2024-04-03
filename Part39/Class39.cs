using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part39
{
    public delegate void MyDelegate();
    internal class Class39
    {

       public static void MainFunction()
        {
        MyDelegate myDelegate1 = new MyDelegate(PrintMyName);
            myDelegate1 += PrintMySemester;

            myDelegate1();

            myDelegate1 -= PrintMyName;
            Console.WriteLine("\n\nAfter removal\n");
            myDelegate1();
    }
        public static void PrintMySemester()
        {
            Console.WriteLine($"6 semester");
        }

        public static void PrintMyName()
        {
            Console.WriteLine($"Majid Khadim");
        }
    }

    
}
