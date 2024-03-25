using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part4
{
    internal class Class4
    {
        public static void Work()
        {
            string MyName = "Majid Khadim";
            Console.WriteLine(MyName);
            Console.WriteLine("Name written in double quotes using escape sqc");
            Console.WriteLine("\" Majid Khadim\"");
            //using verbatim Litaral
            string path = @"C:/user/MyFolder";
            Console.WriteLine(path);
        }
    }
}
