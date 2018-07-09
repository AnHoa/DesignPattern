using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryTestTumlum
{
    class AbClass
    {
        private static int a = 33333;
        public int number { get; set; }
        public int number2 { get; set; }
        static AbClass()
        {
            a = 2;
        }
        public static void sayA()
        {
            Console.WriteLine(a);
        }
    }
}
