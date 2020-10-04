using System;
using System.Threading;
using System.Threading.Tasks;

namespace others
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            execute1();
            Console.WriteLine("after execute 1");
            Console.ReadLine();
        }

        // I don't understand why this method must be marked as `async`.
        static async void execute1()
        {
            Console.WriteLine("Starting .....");
            Task<int> access = DoSomethingAsync();
            // task independent stuff here

            // this line is reached after the 5 seconds sleep from 
            // DoSomethingAsync() method. Shouldn't it be reached immediately? 
            int a = 1;
            Console.WriteLine(a + " testinggggg");
            // from my understanding the waiting should be done here.
            int x = await access;
            Console.WriteLine(x);

            Console.WriteLine("Done");
        }

        static async Task<int> DoSomethingAsync()
        {
            // is this executed on a background thread?
            //Thread.Sleep(5000);
            await Task.Delay(5000);
            Console.WriteLine("Sleeping was done !");
            return 666666;
        }

        static async Task<string> WaitSynchronously()
        {
            // Add a using directive for System.Threading.
            Thread.Sleep(10000);
            return "Finished";
        }
    }
}
