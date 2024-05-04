using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part81
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

            Queue<Customer> queue = new Queue<Customer>();
            queue.Enqueue(customer);
            queue.Enqueue(customer2);
            queue.Enqueue(customer3);
            queue.Enqueue(customer4);

            queue.Dequeue();
            Console.WriteLine(queue.Count);
            queue.Peek();
        }
    }


    
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        
    }
}
