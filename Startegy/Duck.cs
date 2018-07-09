using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startegy
{
    class Duck
    {
        private IFlyBehavior flyBehavior;
        private IQuackBehavior quackbehavior;

        public Duck(IFlyBehavior flybh, IQuackBehavior qukbh)
        {
            flyBehavior = flybh;
            quackbehavior = qukbh;
        }

        public void PerformQuack()
        {
            quackbehavior.Quack();
        }

        public void Performfly()
        {
            flyBehavior.Fly();
        }
    }
}
