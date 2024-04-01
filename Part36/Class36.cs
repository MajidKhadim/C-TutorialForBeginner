using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part36
{
    public delegate void HelloFromDelegate(string s);
    public class Class36
    {
        public static HelloFromDelegate hello = new HelloFromDelegate(Hello);
        public static void Hello(string s)
        {
            Console.WriteLine(s);
        }
    }
}
