using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startegy
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck d1 = new Duck(new FlyMad(), new QuackTo());
            Duck d2 = new Duck(new FlyGood(), new QuackNho());

            d1.Performfly();
            d1.PerformQuack();

            d2.Performfly();
            d2.PerformQuack();
        }
    }
}
