using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part99
{
    internal class Class99
    {
        public static void MainFunction()
        {
            List<Hello> list = new List<Hello>(4);

            list.Add(new Hello() { ID = 7, Name = "Majid" });
            list.Add(new Hello() { ID = 8, Name = "Ahmad" });
            list.Add(new Hello() { ID = 8, Name = "Ali" });

            list.Find((h) =>  h.ID == 7);
        }
    }

    class Hello
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
