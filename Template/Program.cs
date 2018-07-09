using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            CaffeinBaverage tea1 = new Tea();

            CaffeinBaverage coffee1 = new Coffee();

            tea1.Display();
            coffee1.Display();
        }
    }
}
