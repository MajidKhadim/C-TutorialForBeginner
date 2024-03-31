using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.part33
{
    public interface IData
    {
        void PrintInterface();
    }

    public abstract class Data
    {
        public int DataProp {  get; set; }
        public abstract void PrintAbstract();
    }
}
