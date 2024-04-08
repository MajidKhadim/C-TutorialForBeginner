using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part65
{
    public class HelloWorld
    {
        public static void MainFunction()
        {
            Company company = new Company();
            Console.WriteLine("name of employee : " + company[2]);
        }
    }
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

    }

    public class Company
    {
        private List<Employee> employees;
        public Company()
        {
            employees = new List<Employee>();
            employees.Add(new Employee() { ID=1,Name="Majid",Gender="Male"});
            employees.Add(new Employee() { ID = 2, Name = "ALi", Gender = "Male" });
            employees.Add(new Employee() { ID = 3, Name = "Huraira", Gender = "Male" });
        }

        public string this[int id]
        {
            get { return employees.FirstOrDefault(emp => emp.ID == id).Name; }  // for searching we use firstorDefault
            set { employees.FirstOrDefault(emp=>emp.ID ==  id).Name = value; }
        }
    }
}
