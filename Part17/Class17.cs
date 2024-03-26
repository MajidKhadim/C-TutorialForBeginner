using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part17
{
    internal class Class17
    {
        /// <summary>
        /// simple method add 2 and return
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int SimpleMethod(int num)
        {
            return num + 2;
        }
        /// <summary>
        /// By ref make changes in the original argument
        /// </summary>
        /// <param name="num"></param>
        public static void ByRef(ref int num)
        {
            num = 61;
        }
        /// <summary>
        /// takes 4 arguments num1 , num2 , out quot and out mod
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="div"></param>
        /// <param name="mod"></param>
        public static void QuotientAndMod(int num1,int num2,out float div,out int mod)
        {
            div = num1 / num2;
            mod = num2 % num1;
        }

        public static void ParamsMethod(params int[] Numbers)
        {
            Console.WriteLine($"there are {Numbers.Length} elements ");

            foreach(int i in Numbers) Console.WriteLine(i);
        }
    }
}
