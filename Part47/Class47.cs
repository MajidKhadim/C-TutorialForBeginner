using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part47
{
    public enum Gender :int
    {
        Unknown = 1,
        Male = 2,
        Female = 3,
    }
    public class Class47
    {
        public static void MainFunction()
        {
            int[] value = (int[]) Enum.GetValues(typeof(Gender));
            foreach(int value2 in value)
            {
                Console.WriteLine(value2);
            }

            string[] names = (string[]) Enum.GetNames(typeof(Gender));

            foreach (string value2 in names)
            {
                Console.WriteLine(value2);
            }
            Console.WriteLine((int)Gender.Male);
        }
    }
}
