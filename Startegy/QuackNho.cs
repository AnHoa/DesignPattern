using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startegy
{
    class QuackNho : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("quack . . .");
        }
    }
}
