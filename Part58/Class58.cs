using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part58
{
    internal class Class58
    {
        public static void MainFunction()
        {
            Customer customer = new Customer();
            customer.ID = 1;
            customer.Name = "Test";

            Customer customer1 = new Customer();
            customer1.ID = 1;
            customer1.Name
                = "Test";

            Console.WriteLine(customer1 == customer); //compares the reference 

            Console.WriteLine(customer.Equals(customer1)); //compares the values
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            if(obj == null) return false;
            if(!(obj is Customer)) return false;
            return this.ID == ((Customer)obj).ID && this.Name == ((Customer)obj).Name;
        }

        public override int GetHashCode()
        {

            return this.ID.GetHashCode() ^ this.Name.GetHashCode();
        }
    }
}
