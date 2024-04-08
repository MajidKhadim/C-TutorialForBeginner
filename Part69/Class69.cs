using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part69
{
    internal class Class69
    {
        public static void MainFunction()
        {
            //AddNumbers(56, 77);
            //AddNumbers(78, 90, new int[] { 78, 90, 56 });
            test(1,c:12);
        }

        public static void AddNumbers(int firstNumber, int secondNumber, int[] restofNumbers=null)
        {
            int result = firstNumber + secondNumber;
            if (restofNumbers != null)
            {
                foreach (int i in restofNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine("Sum : " + result);
        }

        public static void test(int a,int b=78,int c =90)
        {
            Console.WriteLine($"{a} {b} {c}");
        }
    }
}
