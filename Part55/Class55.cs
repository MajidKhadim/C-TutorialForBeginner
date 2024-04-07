using System;
using System.Reflection;


namespace C_TutorialForBeginner.Part55
{
    internal class Class55
    {
        
        public static void MainFunction()
        {

            Assembly excecutingAssembly = Assembly.GetExecutingAssembly();
            Type T = excecutingAssembly.GetType("C_TutorialForBeginner.Part55.Customer");
            object customerInstance = Activator.CreateInstance(T);

            MethodInfo method = T.GetMethod("GetFullName");

            string[] parameters = new string[2];
            parameters[0] = "Majid";
            parameters[1] = "Khadim";

            string fullName = (string)method.Invoke(customerInstance, parameters);

            Console.WriteLine(fullName);
            //Customer customer = new Customer();
            //string fullName = Customer.GetFullName("Majid", "Khadim");
            //Console.WriteLine(fullName);
        }
    }
    public class Customer
    {
        public static string GetFullName(string FirstName,string LastName)
        {
            return FirstName + " " + LastName;
        }
    }
}
