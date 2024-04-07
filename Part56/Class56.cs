using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part56
{
    internal class Class56
    {
        public static void MainFunction()
        {
            if (Calculator.AreEqual<string>("10", "10"))
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }

    public class Calculator
    {
        public static bool AreEqual<T>(T Value1,T Value2)
        {
            return Value1.Equals(Value2);
        }
    }
}
