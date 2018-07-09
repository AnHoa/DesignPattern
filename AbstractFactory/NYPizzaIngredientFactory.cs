using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Cheese createCheese()
        {
            return new Cheese();
        }

        public Clams createClams()
        {
            return new Clams();
        }

        public Dough createDough()
        {
            return new Dough();
        }

        public Pepperoni createPepperoni()
        {
            return new Pepperoni();
        }

        public Sauce createSauce()
        {
            return new Sauce();
        }

        public Veggies[] createVeggies()
        {
            Veggies[] veggies = new Veggies[] { new Veggies()};
            return veggies;
        }
    }
}
