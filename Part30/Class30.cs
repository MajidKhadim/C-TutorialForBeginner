using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part30
{
    public interface IData
    {
        void Print(); //access modifiers not allowed
    }
    public class Data : IData
    {
        public void Print()  //necessary to implement this method
        {
            Console.WriteLine("Hello World");
        }
    }
}
