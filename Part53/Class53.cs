using System;
using System.Reflection;

namespace C_TutorialForBeginner.Part53
{
    internal class Class53
    {
        public static void MainFunction()
        {
            Type T = Type.GetType("C_TutorialForBeginner.Part53.Customer");

            Console.WriteLine("Full Name : "+T.FullName);
            Console.WriteLine("Just Name : "+T.Name);
            Console.WriteLine("Just the name space : ",T.Namespace);
            PropertyInfo[] properties = T.GetProperties();
            Console.WriteLine("Properties in the Class : ");
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.Name);
            }

            MethodInfo[] methodInfos = T.GetMethods();

            Console.WriteLine("Methods info : ");

            foreach(MethodInfo method in methodInfos)
            {
                Console.WriteLine("method name : "+ method.Name);
                
            }
        }
        
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Customer() 
        {
            this.Id = 1;
            this.Name = string.Empty;
        }
        public Customer(int id,string name) 
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
