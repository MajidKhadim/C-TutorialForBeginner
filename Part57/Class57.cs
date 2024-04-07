using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part57
{
    internal class Class57
    {
        public static void MainFunction()
        {
            Customer C1 = new Customer();
            C1.FirstName = "Majid";
            C1.LastName = "Khadim";

            Console.WriteLine(C1.ToString());
        }
    }

    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {

            return FirstName + " " + LastName;
        }
    }
}
