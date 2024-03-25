using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part7
{
    internal class Class7
    {
        public static void Work()
        {
            //Compiler Conversion
            int Marks = 78;
            float MarksF = Marks; 
            Console.WriteLine(MarksF);

            //Explicit Conversions
            float MarksG = 90.9f;
            Marks = (int)MarksG;
            Console.WriteLine(Marks);
            string MarksS = "67";
            //using Parse and TryParse Methods to convert strings into numbers
            Marks = int.Parse(MarksS);
            Console.WriteLine(Marks);
            //Try Parse first returns boolean that the method got success or not\
            // Then it stores the value in variable given in Out
            string str = "56";
            int result = 0;
            Console.WriteLine(int.TryParse(str,out result));
            Console.WriteLine(result);
        }
    }
}
