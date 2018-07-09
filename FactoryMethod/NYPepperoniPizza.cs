using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class NYPepperoniPizza : Pizza
    {
        public void bake()
        {
            Console.WriteLine("Baking the NYPepperoniPizza . . .");
        }

        public void box()
        {
            Console.WriteLine("Boxing the NYPepperoniPizza . . .");
        }

        public void cut()
        {
            Console.WriteLine("Cuting the NYPepperoniPizza . . .");
        }

        public void prepare()
        {
            Console.WriteLine("Preparing the NYPepperoniPizza . . .");
        }
    }
}
