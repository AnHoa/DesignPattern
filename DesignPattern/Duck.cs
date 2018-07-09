using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Duck
    {
        protected string name;
        protected IQuackBehavior QuackBehavior;

        public Duck(string name)
        {
            this.name = name;
        }

        public Duck(string name, IQuackBehavior quackBehevior)
        {
            this.name = name;
            QuackBehavior = quackBehevior;
        }
        public void Swim()
        {
            Console.WriteLine("Swimming....");
        }

        public void Display()
        {
            Console.WriteLine("Display..");
        }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

    }
}
