using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part27
{
    internal class Class27
    {
        private int _marks;
        private string _name;
        
        public int Marks
        {
            get { return _marks; }
            set {
                if(value > 0)
                {
                    _marks = value;
                }
            }
        }

        public string Name
        {
            get { return this._name; }
            set { 
                if(!string.IsNullOrEmpty(value))
                this._name = value; }
        }
    }
//    Class27 class26 = new Class27();
//    class26.Marks = 78;
//            class26.Name = "Majid";
//            Console.WriteLine(class26.Marks);
//            Console.WriteLine(class26.Name);
}
