using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part29
{
    public class ClassExample
    {
        public int Data { get; set; }
        public static void PrintMyName()
        {
            Console.WriteLine("Majid Khadim");
        }
        public static void PrintMyName(int count)
        {
            while (count >= 0)
            {
                Console.WriteLine("Majid Khadim");
                count--;
            }
        }
    }
    public struct StructExample
    {
        public int Data { get; set; }
        public static void PrintMyName()
        {
            Console.WriteLine("Majid Khadim");
        }
        public static void PrintMyName(int count)
        {
            while (count >= 0)
            {
                Console.WriteLine("Majid Khadim");
                count--;
            }
        }

        //ClassExample classExample1 = new ClassExample();
        //classExample1.Data = 20;
        //    ClassExample classExample2 = classExample1;
        //Console.WriteLine($"classExample 2 data : {classExample2.Data}" +
        //        $"   classExample 1 data : {classExample1.Data}");

        //    classExample1.Data = 30; // making change in classexample 1
        //    Console.WriteLine($"classExample 2 data : {classExample2.Data}" +
        //        $"  classExample 1 data : {classExample1.Data}");


        //    StructExample structExample1 = new StructExample();
        //structExample1.Data = 20;
        //    StructExample structExample2 = structExample1;
        //Console.WriteLine($"structExample 2 data : {structExample2.Data}" +
        //         $"  structExample 1 data : {structExample1.Data}");
            
        //    structExample1.Data= 30;
        //    Console.WriteLine($"structExample 2 data : {structExample2.Data}" +
        //        $"  structExample 1 data : {structExample1.Data}");
    }
}
