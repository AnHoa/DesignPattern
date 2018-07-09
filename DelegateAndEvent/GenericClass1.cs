using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent
{
    class GenericClass1<T>
    {
        public T[] Data { get; private set; }
        public GenericClass1(int n)
        {
            Data = new T[n];
        }

        public T this[int index]
        {
            get
            {
                return Data[index];
            }
            set
            {
                
                Data[index] = value;
            }
        }
    }
}
