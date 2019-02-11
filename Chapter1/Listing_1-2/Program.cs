using System;
using System.Threading;

namespace Chapter1.Listing_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(ThreadMethod);
            t.IsBackground = true;
            t.Start();
        }

        private static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"ThreadProc: {i}");
                Thread.Sleep(1000);
            }
        }
    }
}
