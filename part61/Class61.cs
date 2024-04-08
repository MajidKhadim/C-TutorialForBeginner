using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.part61
{
    public class Class61
    {
        public static void MainFunction()
        {
            Customer customer = new Customer();
            customer.FirstName = "Majid";
            customer.LastName = "Khadim";
            Console.WriteLine(customer.GetFullName());
        }
    }

    public partial class Customer
    {
        private string _firstName;
        private string _lastName;
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }

        
    }
}
