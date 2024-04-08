using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part67
{
    internal class Class67
    {

        public static void MainFunction()
        {
            AddNumbers(56,77,67,90,78);
        }

        public static void AddNumbers(int firstNumber,int secondNumber,params object[] restofNumbers)
        {
            int result= firstNumber + secondNumber;
            if(restofNumbers != null)
            {
                foreach(int i in restofNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine("Sum : "+result);
        }
    }
}
