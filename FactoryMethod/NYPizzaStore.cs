using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class NYPizzaStore : PizzaStore
    {
        public override Pizza createPizza(string type)
        {
            if (type.Equals("cheese"))
            {
                return new NYCheesePizza();
            }
            else if (type.Equals("pepperoni"))
            {
                return new NYPepperoniPizza();
            }
            else return null;
        }
    }
}
