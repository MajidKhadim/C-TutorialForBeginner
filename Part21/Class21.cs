using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part21
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;

        public Employee()
        {
            Console.WriteLine("Employee class");
        }
        public Employee(string msg)
        {
            Console.WriteLine(msg);
        }
        public void PrintFullName()
        {
            Console.WriteLine(FirstName + LastName);
        }
    }

    public class FullTimeEmployee:Employee 
    {
        float YearlySalary;
        public FullTimeEmployee() : base("derived class controlling parent class")
        {
            Console.WriteLine("child class");
        }

    }
    public class PartTimeEmployee : Employee
    {
        float HourlySalary;

    }
}
