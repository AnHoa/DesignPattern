using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public class Coffee : CaffeinBaverage
    {
        public override void addCondiment()
        {
            Console.WriteLine("Adding milk, adding sugar . . .");
        }

        public override void Brew()
        {
            Console.WriteLine("Steeping the coffee . . . ");
        }

        public override void Display()
        {
            Console.WriteLine("Coffee . . .");
        }
    }
}
