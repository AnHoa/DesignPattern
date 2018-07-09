using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class NYCheesePizza : Pizza
    {
        public void bake()
        {
            Console.WriteLine("Baking the NYCheesePizza . . .");
        }

        public void box()
        {
            Console.WriteLine("Boxing the NYCheesePizza . . .");
        }

        public void cut()
        {
            Console.WriteLine("Cuting the NYCheesePizza . . .");
        }

        public void prepare()
        {
            Console.WriteLine("Preparing the NYCheesePizza . . .");
        }
    }
}
