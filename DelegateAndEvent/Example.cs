using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent
{
    class SubEvenArgs : EventArgs
    {
        public int Result { get; set; }

        public SubEvenArgs()
        {

        }

        public SubEvenArgs(int result)
        {
            Result = result;
        }
    }

    internal delegate void ExampleDelegate(string i);
    internal delegate int SubstractionEventHandler(object sender, SubEvenArgs subeventArgs);
    class Example
    {
        public event EventHandler OnAdded;
        public event SubstractionEventHandler OnSubstracted;
        public Example()
        {

        }

        public Example(ExampleDelegate ed)
        {
            int i = 0;
            while(i < 10)
            {
                ed(i.ToString());
                i++;
            }
        }

        public int Addition(int a, int b)
        {
            if(OnAdded != null)
            {
                OnAdded(this, EventArgs.Empty);
            }
            return a + b;
        }

        public int Substraction(int a, int b)
        {
            OnSubstracted?.Invoke(this, new SubEvenArgs(a - b));
            return a - b;
        }

        public void SubDelegate(ExampleDelegate exam, string i)
        {
            exam(i);
        }
    }
}
