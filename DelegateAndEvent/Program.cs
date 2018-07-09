using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent
{
    internal delegate int Calculation(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            //Example e = new Example();
            //Calculation c = e.Addition;
            //e.OnAdded += E_OnAdded;
            //c(3, 6);


            Example d = new Example();
            Calculation f = d.Substraction;
            f += delegate (int a, int b)
            {
                return a + b * 5;
            };
            d.OnSubstracted += new SubstractionEventHandler(D_OnSubstracted);
            Console.WriteLine("KQ: {0}", f(45, 8));
            d.Substraction(348, 5);


            d.SubDelegate(delegate (string i)
            {
                Console.WriteLine(i);
            }, "Deng");


            List<string> List = new List<string>();
            List.Add("Sourav");
            List.Add("Ram");
            List.Add("shyam");
            List.Add("Sachin");
            IEnumerable names = from n in List where (n.StartsWith("S")) select n;

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }


            Func<int, bool> delTaolao = new Func<int, bool>(x => x > 10 ? true : false);
            Func<int, int, bool> delTaolao2 = new Func<int, int, bool>((x, y) => x > y ? true : false);

            Console.WriteLine(delTaolao(33) == true ? "Dung roi haha" : "Sai Cmnr Ahuhu");
            Console.WriteLine(delTaolao2(33,35) == true ? "x lon haha" : "y lon hon haha");

            //List<string> fruits = new List<string> { "apple", "passionfruit", "banana", "mango",
            //        "orange", "blueberry", "grape", "strawberry" };

            //IEnumerable<string> query = fruits.Where(
            //    delegate(string str) {
            //    if (str.Length < 6)
            //        return true;
            //    else
            //        return false;
            //});

            //foreach (string fruit in query)
            //{
            //    Console.WriteLine(fruit);
            //}


            //GEnericClass2<int> values = new GEnericClass2<int>();
            //values.Datas[13] = 23;
            //values.Datas[2] = 35;
            //values.Datas[3] = 3;
            //values.Datas[5] = 0;
            //values.Datas[1] = 23;
            //values.Datas[0] = 35;
            //values.Datas[43] = 2;
            //values.Datas[93] = 3;
            //values.Datas[8] = 3;
            //values.Datas[7] = 1;
            //values.Datas[16] = 40;
            //foreach (int item in values.Where(x => x > 5))
            //{
            //    Console.WriteLine(item);
            //}

            //int a = 7;
            //int b = 0;

            //try
            //{
            //    if (b == 0)
            //    {
            //        throw new DivideByZeroException(); 
            //    }
            //    Console.WriteLine("OK !");
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine("Loi: {0}", e.Message);
            //    throw;
            //}
            //finally
            //{
            //    Console.WriteLine("Ahihi");
            //}

        }

        private static void D_SubDelegate(string s)
        {
            Console.WriteLine(s);
        }

        private static int D_OnSubstracted(object sender, SubEvenArgs e)
        {
            Console.WriteLine("Su kien tru da xay ra ====== {0} ======", e.Result);
            return e.Result;
        }

        private static void E_OnAdded(object sender, EventArgs e)
        {
            Console.WriteLine("===== Su kien da chay =======");
        }
    }
}
