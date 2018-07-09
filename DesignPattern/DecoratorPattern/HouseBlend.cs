using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DecoratorPattern
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            setDescription("HouseBlend");
        }
        public override double cost()
        {
            return 0.89;
        }
    }
}
