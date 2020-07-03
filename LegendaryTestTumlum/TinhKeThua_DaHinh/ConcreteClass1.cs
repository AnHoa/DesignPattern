using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryTestTumlum.TinhKeThua_DaHinh
{
    public class ConcreteClass1 : Ab_Class1
    {
        private static int nCon = 0;


        public ConcreteClass1()
        {
            Increase();
        }

        public int getNCon()
        {
            return nCon;
        }

        public int getNNumber()
        {
            return base.getNumber();
        }

        protected new void Increase()
        {
            nCon += 1;
            base.Increase();
        }
    }
}
