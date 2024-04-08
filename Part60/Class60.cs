using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part60
{
    internal class Class60
    {
        public static void MainFunction()
        {
            string str = "C#";
            str += " Video";
            str += " Beginners";
            str += " Course";  //everytime creates a new string and copy the value in this string they resides in memory until the garbage collector runs and clear the memory
            Console.WriteLine(str);

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(str);
            Console.WriteLine(stringBuilder.ToString()); //creates single object on heap and its mutable when we make changes it changes and does not craete a new object
        }
    }
}
