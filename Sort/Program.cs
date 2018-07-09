using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Cho c1 = new Cho(32);
            Sort.changetuoicho(c1);
            Console.WriteLine(c1.tuoi);

            int[] a = new int[] { 3, 8, 4, 6, 2, 5, 7, 1, 9, 0 };
            int b = 8763;
            Sort.Insert(b);
            Console.WriteLine(b);


            a = Sort.MergeSort(a, 0, 9);   
            Sort.Insert(a);
            foreach (int x in a)
            {
                Console.Write(x.ToString() + "  ");
            }
        }
    }
}
