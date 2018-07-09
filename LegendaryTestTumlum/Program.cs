using System;

namespace LegendaryTestTumlum
{

    class ReadOnlyEx
    {
        public readonly int number = 10;
        public ReadOnlyEx()
        {
            number = 20;
        }
        public ReadOnlyEx(bool IsDifferentInstance)
        {
            number = 100;
        }
    }
    class Program
    {
        static string DaoNguocTen(string tenGoc)
        {
            string res = "";
            int i = 0;
            while (i < tenGoc.Length)
            {
                if (tenGoc[i].Equals(' '))
                {
                    res = tenGoc[i] + res;
                    i++;
                }
                else
                {
                    string tmp = "";
                    while (i < tenGoc.Length && !tenGoc[i].Equals(' '))
                    {
                        tmp = tmp + tenGoc[i];
                        i++;
                    }
                    res = tmp + res;
                }
            }
            return res;
        }

        static void TamGiacCan(int n)
        {
            int a = n * 2 - 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= a; j++)
                {
                    if (i == 1)
                    {
                        if ((j % 2) != 0)
                            Console.Write('*');
                        else
                            Console.Write(' ');
                    }
                    else if (j == i || j == (a - i + 1))
                        Console.Write('*');
                    else if ((i % 2) == (j % 2) && (j > i) && (j < a - i + 1))
                        Console.Write('*');
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        private static Tuple<int, int> GetRange()
        {
            var x = new Tuple<int, int>(2, 3);
            return x;
        }


        static void ChuNhat()
        {
            int W = 0, H = 0;
            Console.Write("Width: ");
            W = int.Parse(Console.ReadLine());

            Console.Write("Height: ");
            H = int.Parse(Console.ReadLine());
            Console.WriteLine(W + " " + H);

            W = 1 + (W - 1) * 4;
            H = H * 2 - 1;

            for (int i = 0; i < H; i++)
            {
                for (int j = 0; j < W; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j == 0 || j == W - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            if ((i == 0 || i == H - 1) && j % 4 == 0)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {

            //TupleTest ts = new TupleTest(233, 322);
            //Console.WriteLine(ts.getData1().Item1 + "  " + ts.getData1().Item2);
            //ListProducts lst1 = new ListProducts();

            //lst1[0] = new Product { id = 23, tensp = "ko biet" };

            //Console.WriteLine(lst1[0].id);


            //AbClass sd = new AbClass { number = 2, number2 = 34 };


            //Console.WriteLine(DaoNguocTen("  a  Nguyen Binh An s ") + "||||");
            //TamGiacCan(8);

            
            

        }

    }


    //////////////////////////////////////////////////

}

