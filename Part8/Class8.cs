using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part8
{
    internal class Class8
    {
        public static void Work()
        {
            int var1 = 56;
            int var2 = 89;
            Console.WriteLine($" {var1} and {var2}");
            //for creating variables of similar datatype we can use arrays a compact way to write code
            int[] arr = {56, 89};
            Console.WriteLine($" {arr[0]} and {arr[1]}");

            // we can also reassign values to the indexes and then print them on screen
            arr[0] = 90;
            arr[1] = 89;
            Console.WriteLine($" {arr[0]} and {arr[1]}");

            // But if i try to write the index which is not present then it will raise exception and terminates
            Console.WriteLine(arr[9]);
        }
    }
}
