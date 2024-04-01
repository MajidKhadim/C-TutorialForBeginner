using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part35
{
    public interface IA
    {
        void PrintA();
    }

    public interface IB
    {
        void PrintB();
    }

    public class A : IA
    {
        public void PrintA()
        {
            Console.WriteLine("A class");
        }
    }

    public class B : IB
    {
        public void PrintB()
        {
            Console.WriteLine("B class");
        }
    }

    public class AB : IA, IB
    {
        A aObj = new A();
        B bObj = new B();
        public void PrintA()
        {
            aObj.PrintA();
        }

        public void PrintB()
        {
           bObj.PrintB();
        }
    }
}
