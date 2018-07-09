using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Sub1 : SuperClass1
    {
        public void sub1()
        {
            Console.WriteLine("sub ne");
        }

        protected void proMethod()
        {
            Console.WriteLine("proMethod1");
        }
    }
}
