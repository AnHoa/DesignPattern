using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.DecoratorPattern;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Duck sd = new Duck("Donald", new ShortQuack());
            //sd.PerformQuack();

            
            Beverage beverage = new Espresso();
            beverage = new Mocha(beverage);
            beverage = new Mocha(beverage);
            beverage = new FreshMilk(beverage);
            
            Console.WriteLine(beverage.getDescription() + "  $" + beverage.cost());

            //Student student1 = new Student("Duyen", 22);

            //Console.WriteLine(student1.GetTuoi());
           
        }
    }
}
