using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part46
{
    public enum Gender
    {
        Unknown,
        Male,
        Female
    }
    public class Enums
    {
        public static void MainFunction()
        {
            Customer[] customers = new Customer[3];

            customers[0] = new Customer()
            {
                Name = "Test",
                Gender = Gender.Unknown
            };
            customers[1] = new Customer
            {
                Name = "Test2",
                Gender = Gender.Male
            };
            customers[2] = new Customer
            {
                Name = "Test3",
                Gender = Gender.Female
            };

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Name + " and gender : " + GetGender(customer.Gender));
            }
        }
        public static string GetGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Unknown:
                    {
                        return "Unknown";
                    }
                case Gender.Male:
                    {
                        return "Male";
                    }
                case Gender.Female:
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
        public Gender Gender { get; set; }
    }
}
