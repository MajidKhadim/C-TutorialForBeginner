using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part45
{
    public class Enums
    {
        public static void MainFunction()
        {
            Customer[] customers = new Customer[3];

            customers[0] = new Customer()
            {
                Name = "Test",
                Gender = 1
            };
            customers[1] = new Customer
            {
                Name = "Test2",
                Gender = 2
            };
            customers[2] = new Customer
            {
                Name = "Test3",
                Gender = 0
            };

            foreach(Customer customer in customers)
            {
                Console.WriteLine(customer.Name + " and gender : "+GetGender(customer.Gender));
            }
        }
        public static string GetGender(int gender)
        {
            switch(gender)
            {
                case 0:
                    {
                        return "Unknown";
                    }
                case 1:
                    {
                        return "Male";
                    }
                case 2:
                    {
                        return "Female";
                    }
                default:
                    {
                        return "Invalid Data";
                    }
            }
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public int Gender { get; set; }
    }

}
