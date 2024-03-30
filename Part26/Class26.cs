using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part26
{
    internal class Class26
    {
        private int _marks;
        private string _name;
        public int GetMarks()
        {
            return this._marks;
        }
        public string GetName()
        {
            return this._name;
        }

        public void SetMarks(int marks)
        {
            if(marks > 50)
            this._marks = marks;
        }
        public void setName(string name)
        {
            if(!string.IsNullOrEmpty(name))
            this._name = name;
            else this._name = "No Name";
        }
    }
    //Class26 class26 = new Class26();
    //class26.SetMarks(89);
    //        class26.setName("");
    //        Console.WriteLine(class26.GetMarks());
    //        Console.WriteLine(class26.GetName());
}
