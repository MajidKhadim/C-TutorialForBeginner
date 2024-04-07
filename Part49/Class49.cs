using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part49
{
    public class PrClass
    {
        private int _id; // only accessed in this class
        public int ID { get { return _id; } set { _id = value; } }
        private string _name;
        // protected only accessed in this class and derived class
        protected string Name { get { return _name; } set { _name = value; } }
    }

    public class PrChild : PrClass
    {
        public PrChild() { base.Name="hello"; }
        public static void Hello()
        {
            Console.WriteLine();
        }
    }

    class Class49
    {
        public static void MainFunction()
        {
            PrClass prClass = new PrClass();
            prClass.ID = 1; // only can access ID as it is public
        }
    }
}
