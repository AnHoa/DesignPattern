using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DecoratorPattern
{
    public abstract class Beverage
    {
        protected string Description = "Unknown Beverage";

        public virtual string getDescription()
        {
            return Description;
        }

        public void setDescription(string description)
        {
            Description = description;
        }

        public abstract double cost();
    }
}
