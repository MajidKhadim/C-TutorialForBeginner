using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part50
{
    public class Class50
    {
        internal int hello = 10; // we can only access this in same assembly and cant in different assembly
        protected internal int hello2 = 20; // only can be accessed in same assembly and in other assembly if the class is parent class of the using class
    }
}
