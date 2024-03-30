using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part24
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

            public void CheckHiding()
            {
                Console.WriteLine("parent");
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
            public new void CheckHiding()
            {
                Console.WriteLine("parent");
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
    //Employee employee = new FullTimeEmployee();

    //employee.PrintFullName(); // fulltime class method called as overriding is used;
    //        Employee employee1 = new FullTimeEmployee();
    //employee1.CheckHiding(); // base class method
    }
