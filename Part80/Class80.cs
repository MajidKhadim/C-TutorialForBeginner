using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part80
{
    internal class Class80
    {


        public static void MainFunction()
        {

           


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
           
            Customer customer6 = new Customer() { Id = 0, Name = "Foo", Description = "Bar", };
            list.Add(customer6);
            
            //Console.WriteLine("before sorting");
            //foreach (Customer i in list)
            //{
            //    Console.WriteLine(i.Id);
            //}


            //Console.WriteLine("after sorting");
            //foreach (Customer i in list)
            //{
            //    Console.WriteLine(i.Id);
            //}

            Console.WriteLine(list.TrueForAll(cus => cus.Id < 10));
        }


        
    }


    
    public class Customer : IComparable<Customer>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int CompareTo(Customer other)
        {
            if (this.Id > other.Id)
                return 1;
            else if (this.Id < other.Id)
                return -1;
            else
                return 0;

        }
    }
}
