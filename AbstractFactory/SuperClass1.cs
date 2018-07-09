using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class SuperClass1
    {
        public void Super1()
        {
            Console.WriteLine("Super ");
        }

        protected void proMethodSuper()
        {
            Console.WriteLine("Pro super");
        }
    }
}
