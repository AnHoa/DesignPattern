using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbulence
{
    class Program
    {
        static void Main(string[] args)
        {

            TubOwner a = new TubOwner();

            Tub t1 = a.getTubContext();
            t1.DisplayTheJOKE();

            int[] arr = { 3, 4, 3, 8, 2, 1, 7, 1, 5, 6, 8, 3 };

            int curMax = 2;
            int tmp = 2;
            bool tmpFlag = true;
            bool Flag = arr[0] - arr[1] > 0 ? true : false;
            for (int i = 2; i < arr.Length; i++)
            {
                tmpFlag = arr[i - 1] - arr[i] > 0 ? true : false;
                if (tmpFlag != Flag)
                {
                    tmp = tmp + 1;
                    Flag = tmpFlag;
                }
                else
                {
                    if (tmp > curMax)
                        curMax = tmp;
                    tmp = 2;
                }
                //Console.WriteLine(tmp);
            }
            if (tmp > curMax)
                curMax = tmp;
            Console.WriteLine(curMax);
        }
    }
}
