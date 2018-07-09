using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class RedQuack : Duck
    {
        public RedQuack(string name) : base(name)
        {
            
        }

        public RedQuack(string name, IQuackBehavior quackBehevior) : base(name, quackBehevior)
        {
        }
    }
}
