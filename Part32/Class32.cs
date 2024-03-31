using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part32
{
    public abstract class AbstractClass
    {
        public int Hello {  get; set; }
        public abstract void Print();

    }
    public class Class32:AbstractClass
    {
        public override void Print()
        {
            this.Hello = 10;
            Console.WriteLine(Hello);
        }
    }
    ////AbstractClass abstractClass = new AbstractClass();  cant do it because it is abstract class
    //Class32 class32 = new Class32();
    //class32.Print();
}
