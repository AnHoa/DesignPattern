using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Tea : CaffeinBaverage
    {
        public override void addCondiment()
        {
            Console.WriteLine("Adding lemons . . . . . . .");
        }

        public override void Brew()
        {
            Console.WriteLine("Steeping the tea . . .");
        }

        public void Display()
        {
            Console.WriteLine("Tea . . .");
        }
    }
}
