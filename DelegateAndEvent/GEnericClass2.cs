using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent
{
    class GEnericClass2<T>
    {
        public T[] Datas { get; }

        public GEnericClass2()
        {
            Datas = new T[100];
        }

    }
}
