using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.part61
{
    public partial class Customer
    {
        public string GetFullName()
        {
            return _firstName + " " + _lastName;
        }
    }
}
