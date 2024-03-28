using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part20
{
    internal class Class20
    {
        string Name;
        int? RollNo;
        public Class20()
        {
            this.RollNo = null;
            this.Name = null;
            Console.WriteLine("Main bhi");
        }

        static Class20()
        {
            Console.WriteLine("static hoo main");
        }

        
        public void PrintMyName()
        {
            Console.WriteLine($"My Name is {Name} and {RollNo}");
        }

    }
}
