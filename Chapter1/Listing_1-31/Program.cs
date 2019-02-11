using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1.Listing_1_31
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();

            Task.Run(() =>
            {
                bag.Add(42);
                Thread.Sleep(1_000);
                bag.Add(21);
            });

            Task.Run(() =>
            {
                Thread.Sleep(5_00);
                foreach (int i in bag)
                {
                    Console.WriteLine(i);
                }
            }).Wait();
        }
    }
}
