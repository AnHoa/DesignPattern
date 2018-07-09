using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DecoratorPattern
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            setDescription("Espresso");
        }
        public override double cost()
        {
            return 1.99;
        }
    }
}
