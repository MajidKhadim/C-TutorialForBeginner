using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part81
{
    internal class Class83
    {
        internal class Class82
        {


            public static void MainFunction()
            {


                Customer customer = new Customer()
                {
                    Id = 1,
                    Name = "1",
                    Description = "Bar",
                };
                Customer customer2 = new Customer()
                {
                    Id = 2,
                    Name = "2",
                    Description = "Bar",
                };
                Customer customer3 = new Customer()
                {
                    Id = 3,
                    Name = "3",
                    Description = "Bar",
                };
                Customer customer4 = new Customer()
                {
                    Id = 4,
                    Name = "4",
                    Description = "Bar",
                };

                Stack<Customer> stack = new Stack<Customer>();
                stack.Push(customer);
                stack.Push(customer2);
                stack.Push(customer3);
                stack.Push(customer4);

                Console.WriteLine(stack.Pop().Name);

                Console.WriteLine(stack.Peek().Name);
            }
        }



        public class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }


        }
    }
}
