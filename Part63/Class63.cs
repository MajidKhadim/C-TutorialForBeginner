using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part63
{
    internal class Class63
    {
        public static void MainFunction()
        {
            SamplePartialClass.PublicMethod();
        }
    }

    public partial class SamplePartialClass
    {
        static partial void PartialMethod();

        public static void PublicMethod()
        {
            Console.WriteLine("Public method invoked");
            PartialMethod();
        }
    }
}
