using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part48
{
    public class Customer
    {
        private int _id;
        public int Id { get { return _id; } set { _id = value; } }
        private string _firstname;
        public string Firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        private string _lastname;
        public string Lastname { get { return _lastname; }
            set { _lastname = value; }
        }
    }

}
