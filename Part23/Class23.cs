using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part23
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public virtual void PrintFullName()
        {
            Console.WriteLine("EMployee class");
        }
    }

    public class FullTimeEmployee : Employee
    {
        float YearlySalary;
        public FullTimeEmployee()
        {
           // Console.WriteLine("child class");
        }
        public override void PrintFullName()
        {
            Console.WriteLine("full time");
        }
    }
    public class PartTimeEmployee : Employee
    {
        float HourlySalary;
        public override void PrintFullName()
        {
            Console.WriteLine("part time ");
        }
    }
}

//Employee[] employees = new Employee[3];
//employees[0] = new Employee();
//employees[1] = new FullTimeEmployee();
//employees[2] = new PartTimeEmployee();

//foreach (Employee employee in employees)
//{
//    employee.PrintFullName();
//}
