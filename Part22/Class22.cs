using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part22
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public void PrintFullName()
        {
            Console.WriteLine(FirstName + LastName);
        }
    }

    public class FullTimeEmployee : Employee
    {
        float YearlySalary;
        public FullTimeEmployee()
        {
            Console.WriteLine("child class");
        }
        public new void PrintFullName()
        {
            Console.WriteLine(FirstName + LastName+"child class");
        }
    }
    public class PartTimeEmployee : Employee
    {
        float HourlySalary;
        public new void PrintFullName()
        {
            Console.WriteLine(FirstName + LastName + "child class");
        }

    }
}
