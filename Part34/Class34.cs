using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part34
{
    public class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A implementation");
        }
    }

    public class B : A 
    {
        public override void Print()
        {
            Console.WriteLine("B implementation");
        }
    }
    public class C : A
    {
        public override void Print()
        {
            Console.WriteLine("C implementation");
        }
    }

    public class D : B//, C  // givrs error
    {

    }
}
