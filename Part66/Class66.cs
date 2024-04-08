using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part66
{
    public class Class66
    {
        public static void MainFunction()
        {
            Company company = new Company();
            // for changing the name of employee we can simple write
            //company[2] = "Ali";
            //Console.WriteLine("name of employee : " + company[2]);
            Console.WriteLine("before updation");
            Console.WriteLine(company["Male"]);
            Console.WriteLine("after updation");
            company["Male"] = "Female";
            Console.WriteLine(company["Male"]);


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
            employees.Add(new Employee() { ID = 1, Name = "Majid", Gender = "Male" });
            employees.Add(new Employee() { ID = 2, Name = "ALi", Gender = "Male" });
            employees.Add(new Employee() { ID = 3, Name = "Huraira", Gender = "Male" });
        }

        public string this[int id]
        {
            get { return employees.FirstOrDefault(emp => emp.ID == id).Name; }  // for searching we use firstorDefault
            set { employees.FirstOrDefault(emp => emp.ID == id).Name = value; }
        }
        public string this[string Gender]
        {
            get { return employees.Count(emp => emp.Gender == Gender).ToString(); }
            set
            {
                foreach (Employee employee in employees)
                {
                    if (employee.Gender == Gender)
                    {
                        employee.Gender = value;
                    }
                }
            }
        }
    }
}
