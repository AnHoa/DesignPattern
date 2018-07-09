using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperClass1 s1 = new sub2();
            int[][] data = new int[8][];
            for (int i = 0; i < 8; i++)
            {
                data[i] = new int[8];
                for (int j = 0; j < 8; j++)
                {
                    data[i][j] = j + 8 * i;
                }
            }


            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write("{0:d2}   ", data[i][j]);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine("=========================/////=============================");
            Console.WriteLine();
            int x = 0, y = 0;
            int count = 1;
            int k = 1;
            while (count <= 63)
            {
                //Console.Write(y + "-" + x + "   ");
                Console.Write("{0:d2}  - ", data[y][x]);
                if (x == 0 || y == 0 || x == 7 || y == 7)
                {
                    if (x == y)
                    {
                        if (x == 0)
                            x = x + 1;
                    }
                    else if (x == 0 || x == 7)
                    {
                        if (x == 0 && y == 7)
                        {
                            x = x + 1;
                            k = k * -1;
                        }

                        else
                        {
                            y = y + 1;
                            k = k * -1;
                        }
                    }

                    else if (y == 0 || y == 7)
                    {
                        x = x + 1;
                        k = k * -1;
                    }

                    //Console.Write(y + "-" + x + "   ");
                    Console.Write("{0:d2}  - ", data[y][x]);
                    count = count + 1;
                    if (x - k >= 0 && x - k <= 7)
                        x = x - k;
                    if (y + k >= 0 && y + k <= 7)
                        y = y + k;
                    count = count + 1;
                }
                else
                {
                    if (x - k >= 0 && x - k <= 7)
                        x = x - k;
                    if (y + k >= 0 && y + k <= 7)
                        y = y + k;
                    count = count + 1;
                }

            }
        }
    }
}
