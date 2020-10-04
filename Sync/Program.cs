using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQuay
{
    class Program
    {
        static void Main(string[] args)
        {

            //MyMethodAsync();
            //MyMethodAsync_2();
            //Console.WriteLine("Ra truoc roi ne");
            Test();
            string a = Console.ReadLine();
        }


        public static void Test()
        {
            //await Task.Delay(0);
            Task<int> task1 = D2();
            Task<int> task2 = D1();
            //Task.WhenAll(task1, task2);
            Console.WriteLine("Omha");
            //Console.WriteLine(task1.Result);
            //Console.WriteLine(task2.Result);
        }


        public static async Task<int> D1()
        {
            int res = 0;
            for (int i = 0; i < 20; i++)
            {
                Task.Delay(135);
                res = res + i;
                Console.WriteLine(" 1");
            }
            //Console.WriteLine(res);
            return res;
        }

        public static async Task<int> D2()
        {
            int res = 0;
            for (int i = 0; i < 20; i++)
            {
                await Task.Delay(120);
                res = res + i;
                Console.WriteLine("            22");
            }
            //Console.WriteLine(res);
            return res;
        }


        public static async void MyMethodAsync()
        {
            await Task.Delay(20);
            Task<int> longRunningTask = LongRunningOperationAsync();
            // independent work which doesn't need the result of LongRunningOperationAsync can be done here
            //await Task.Delay(200);
            Console.WriteLine("s");
            Console.WriteLine("0");
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            //and now we call await on the task 
            int result = await longRunningTask;
            //use the result 
            Console.WriteLine(result);
        }

        public static async Task<int> LongRunningOperationAsync() // assume we return an int from this long running operation 
        {
            await Task.Delay(1000); // 1 second delay
            Console.WriteLine("wait me");
            await Task.Delay(1000); // 1 second delay
            Console.WriteLine("wait me 2");
            await Task.Delay(1000); // 1 second delay
            Console.WriteLine("wait me 3");
            await Task.Delay(1000); // 1 second delay
            Console.WriteLine("wait me 4");
            return 1;
        }

        public static async Task MyMethodAsync_2()
        {
            Task<int> longRunningTask = LongRunningOperationAsync_2();
            // independent work which doesn't need the result of LongRunningOperationAsync can be done here
            //await Task.Delay(200);
            Console.WriteLine("s");
            Console.WriteLine("A");
            Console.WriteLine("B");
            Console.WriteLine("C");
            Console.WriteLine("D");
            Console.WriteLine("E");
            //and now we call await on the task 
            int result = await longRunningTask;
            //use the result 
            Console.WriteLine(result);
        }

        public static async Task<int> LongRunningOperationAsync_2() // assume we return an int from this long running operation 
        {
            await Task.Delay(400); // 1 second delay
            Console.WriteLine("Nguyen");
            await Task.Delay(200); // 1 second delay
            Console.WriteLine("Ngoc");
            await Task.Delay(600); // 1 second delay
            Console.WriteLine("Anh");
            await Task.Delay(800); // 1 second delay
            Console.WriteLine("Kute");
            return 1;
        }
    }
}