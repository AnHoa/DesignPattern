using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryTestTumlum
{
    class TupleTest
    {
        private Tuple<int, int> Data1;
        public TupleTest(int a, int b)
        {
            var x = new Tuple<int, int>(a, b);
            Data1 = x;
        }

        public Tuple<int, int> getData1()
        {
            return Data1;
        }
    }
}
