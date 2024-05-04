using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part79
{
    internal class Class79
    {


        public static void MainFunction()
        {

            List<int> numbers = new List<int>() { 5, 6, 2, 1, 8, 4 };
            numbers.Sort();
            Console.WriteLine(numbers);


            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}
            //numbers.Reverse();
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}
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

            //Console.WriteLine(list.GetRange(1, 3))
            //;
            Customer customer6 = new Customer() { Id = 0, Name = "Foo", Description = "Bar", };
            list.Add(customer6);
            //Console.WriteLine("before sorting");
            //foreach (Customer i in list)
            //{
            //    Console.WriteLine(i.Id);
            //}

            //list.Sort();
            //Console.WriteLine("after sorting");
            //foreach (Customer i in list)
            //{
            //    Console.WriteLine(i.Id);
            //}

            //SortByName sortByName = new SortByName();
            //list.Sort(sortByName);
            Console.WriteLine("before sorting");
            foreach (Customer i in list)
            {
                Console.WriteLine(i.Id);
            }
            Comparison<Customer> customerComparer = new Comparison<Customer>(CompareCustomer);

            list.Sort(customerComparer);

            Console.WriteLine("after sorting");
            foreach (Customer i in list)
            {
                Console.WriteLine(i.Id);
            }
        }


        private static int CompareCustomer(Customer x, Customer y)
        {
            return x.Id.CompareTo(y.Id);
        }
    }


    public class SortByName : IComparer<Customer>
    {
        public int Compare(Customer c1, Customer c2)
        {
            return c1.Name.CompareTo(c2.Name);
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
