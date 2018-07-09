using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startegy
{
    class QuackTo : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("QUACK QUACK QUACK . . .");
        }
    }
}
