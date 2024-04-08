using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part62
{
    internal class Class62
    {
        public static void MainFunction()
        {
            //PartialCustomer customer = new PartialCustomer(); gives error when we used abstract keyword with one part
        }
    }
    public interface IData
    {

    }

    public  partial class PartialCustomer:IData
    {

    }

}
