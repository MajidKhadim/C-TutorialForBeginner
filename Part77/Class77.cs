using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part77
{
    internal class Class77
    {
       
        
        public static void MainFunction()
        {

            List<int> numbers = new List<int>() { 5, 6, 2, 1, 8, 4 };
            numbers.Sort();
            Console.WriteLine(numbers);


            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            numbers.Reverse();
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Customer customer = new Customer()
            {
                Id = 1,
                Name = "Foo",
                Description = "Bar",
            };
            Customer customer2 = new Customer()
            {
                Id = 2,
                Name = "Foo",
                Description = "Bar",
            };
            Customer customer3 = new Customer()
            {
                Id = 3,
                Name = "Foo",
                Description = "Bar",
            };
            Customer customer4 = new Customer()
            {
                Id = 4,
                Name = "Foo",
                Description = "Bar",
            };

            List<Customer> list = new List<Customer>(2);
            list.Add(customer);
            list.Add(customer2);

            List<Customer> corporate = new List<Customer>(2);
            corporate.Add(customer3);
            corporate.Add(customer4);
            list.AddRange(corporate);
            //Console.WriteLine(list.Count);

            //Console.WriteLine(list.GetRange(1, 3));

        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
