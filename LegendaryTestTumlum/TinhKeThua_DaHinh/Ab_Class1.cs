using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryTestTumlum.TinhKeThua_DaHinh
{
    public abstract class Ab_Class1
    {
        protected static int n_Num = 0;

        protected string Name;


        public Ab_Class1()
        {
            Name = "N/A";
        }

        protected int getNumber()
        {
            return n_Num;
        }

        protected void Increase()
        {
            n_Num += 1;
        }
    }
}
