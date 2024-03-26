using ProjectA.TeamA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part18
{
    internal class Class18
    {
        public static void Work()
        {
            ProjectA.TeamA.ClassA.Print();
            ProjectA.TeamB.ClassA.Print();
        }
    }
}
namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team A class A called");
            }
        }
    }
}
namespace ProjectA
{
    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team B class A called");
            }
        }
    }
}