using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part38
{
    public delegate bool IsPromoteAble(Employee employee);
    internal class Class38
    {
        public static void MainFunction()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { ID = 1, Name = "Amad", Salary = 687788, Experience = 4 });
            employees.Add(new Employee() { ID = 2, Name = "abcd", Salary = 687788, Experience = 5 });
            employees.Add(new Employee() { ID = 2, Name = "abcde", Salary = 687788, Experience = 6 });
            employees.Add(new Employee() { ID = 2, Name = "abcdefg", Salary = 687788, Experience = 2 });
            employees.Add(new Employee() { ID = 2, Name = "abcdhij", Salary = 687788, Experience = 3 });
            //IsPromoteAble isPromoteAble = new IsPromoteAble(Promote);
            Employee.PromoteEmployee(employees,emp=> emp.Experience >=5);
        }
        public static bool Promote(Employee employee )
        {
            return employee.Experience >= 5;
        }
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> empList,IsPromoteAble isPromoteAble)
        {
            foreach (Employee employee in empList)
            {
                if (isPromoteAble(employee))
                {
                    Console.WriteLine($"{employee.Name} is Promoted");
                }
            }
        }
    }
}
