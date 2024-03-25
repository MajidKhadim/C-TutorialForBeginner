using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part3
{
    internal class DataTypes
    {
        public static void Work()
        {
            //Boolean Datatype
            bool AreYouLearning = true;
            //Integral Datatypes (sbyte,byte,char,short,ushort,long,ulong,int,uint)
            //How i can check the range of a integral datatype;;
            long earning = 7687678687;
            if( AreYouLearning )
            {
                Console.WriteLine($"Min : {int.MinValue}");
                Console.WriteLine($"Max : {int.MaxValue}");
                Console.WriteLine($"Earning {earning}");
            }

        }
    }
}
