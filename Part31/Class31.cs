using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part31
{
    public interface IData
    {
        void Hello();
    }

    public interface IData2
    {
        void Hello();
    }

    public class Class31 : IData, IData2
    {
        void  IData.Hello() 
        {
            Console.WriteLine("Hello World");
        }

        void IData2.Hello() { Console.WriteLine("Idata 2 method"); }
    }

    //Class31 class31 = new Class31();
    //((IData) class31).Hello();
    //((IData2) class31).Hello();
}
