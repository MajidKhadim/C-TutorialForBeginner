using System;
using System.Runtime.InteropServices;

namespace C_TutorialForBeginner.Part70
{
    internal class Class70
    {
        public static void MainFunction()
        {
            AddNumbers(56, 77);
            //AddNumbers(78, 90, new int[] { 78, 90, 56 });
            //test(1, c: 12);
        }

        public static void AddNumbers(int firstNumber, int secondNumber, [Optional] int[] restofNumbers)
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

        public static void test(int a, int b = 78, int c = 90)
        {
            Console.WriteLine($"{a} {b} {c}");
        }
    }
}
