using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryTestTumlum.TinhKeThua_DaHinh
{
    public class Human : Interface1, Interface2
    {
        public int Age { get; set; }
        public void DisplayValue(int x)
        {
            throw new NotImplementedException();
        }

        public void DisplayValue(int x, int y)
        {
            throw new NotImplementedException();
        }

        public void Say()
        {
            Console.WriteLine("Hello I'm a Human ");
        }
    }
}
