using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part68
{
    internal class Class68
    {
        public static void MainFunction()
        {
            AddNumbers(56, 77,new int[] {30,40});
        }

        public static void AddNumbers(int firstNumber, int secondNumber, int[] restofNumbers)
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
        public static void AddNumbers(int FN,int SN)
        {
            Console.WriteLine("Sum : "+FN+SN);
        }
    }
}
