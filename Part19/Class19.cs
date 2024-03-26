using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part19
{
    internal class Class19
    {
        string _firstName;
        string _lastName;
        public Class19():this("No first name provided","no last name provided") { }
        public Class19(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine($"FullName is {this._firstName} {this._lastName}");
        }

        ~Class19()
        {
            Console.WriteLine("Destructor called");
        }
    }
}
