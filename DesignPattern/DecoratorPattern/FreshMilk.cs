using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DecoratorPattern
{
    public class FreshMilk : CondimentDecorator
    {
        private Beverage beverage;
        public FreshMilk(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override double cost()
        {
            return 0.3 + beverage.cost();
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", FreshMilk";
        }

        public void sayFreshMilk()
        {
            Console.WriteLine("FreshMilk !!!");
        }
    }
}
