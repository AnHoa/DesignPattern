using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public abstract class CaffeinBaverage
    {
        public void prepareRecipe()
        {
            boilWater();
            Brew();
            pourInCup();
            addCondiment();
        }

        public void boilWater()
        {
            Console.WriteLine("Boiling . . . Done !");
        }

        public void pourInCup()
        {
            Console.WriteLine("PourInCup, Doing . . . Done !");
        }

        public abstract void Brew();

        public abstract void addCondiment();

        public virtual void Display()
        {
            Console.WriteLine("CaffeinBaverage . . .");
        }
    }
}
