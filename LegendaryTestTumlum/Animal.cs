using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryTestTumlum
{
    public abstract class Animal : AnimalAction
    {
        public abstract void Chay();

        public abstract void Keu();
        
        public void Tho()
        {
            Console.WriteLine("THo . . . . . . ");
        }
    }
}
