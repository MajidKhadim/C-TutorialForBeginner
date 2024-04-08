using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part63
{
    public partial class SamplePartialClass
    {
        static partial void PartialMethod()
        {
            Console.WriteLine("Partial method invoked");
        }
    }
}
