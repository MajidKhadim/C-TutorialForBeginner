using System;
using System.Collections.Generic;

namespace C_TutorialForBeginner.Part52
{
    public class MainClass
    {
        public static void MainFunction()
        {
            Console.WriteLine(Calculator.Add(45, 56));
        }
    }

    public class Calculator
    {
        [Obsolete("use Add(List<int> Numbers) Method")]
        public static int Add(int FN,int SN)
        {
           return FN + SN;
        }

        public static int Add(int FN,int SN,int TN)
        {
            return FN + SN + TN;
        }

        public static int Add(params int[] values)
        {
            int sum = 0;
            foreach (int i in values) 
            { 
                sum += i;
            }
            return sum;
        }
    }
}
