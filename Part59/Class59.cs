using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part59
{
    internal class Class59
    {
        public static void MainFunction()
        {
            User user = new User();
            User user2 = null;
            Console.WriteLine(user.ToString());
            Console.WriteLine(Convert.ToString(user));

            Console.WriteLine(user2.ToString());  // gives null reference exception
            Console.WriteLine(Convert.ToString(user2));
        }

        public class User
        {
            public string Name { get; set; }
        }
    }

    
}
