using System;
using System.Threading;

namespace Chapter1.Listing_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stopped = false;
            Thread thread = new Thread(new ThreadStart(() =>
            {
                while (!stopped)
                {
                    Console.WriteLine("Running...");
                    Thread.Sleep(1000);
                }
            }));
            thread.Start();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            stopped = true;

            thread.Join();
        }

    }
}
