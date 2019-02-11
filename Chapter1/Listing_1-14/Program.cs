using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1.Listing_1_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            const int timeout = 1000;

            List<Task> tasks = new List<Task>
            {
                Task.Run(() => {
                    int index = ++i;
                    Thread.Sleep(timeout);
                    Console.WriteLine($"{index}");
                    return index;
                }),
                Task.Run(() => {
                    int index = ++i;
                    Thread.Sleep(timeout);
                    Console.WriteLine($"{index}");
                    return index;
                }),
                Task.Run(() => {
                    int index = ++i;
                    Thread.Sleep(timeout);
                    Console.WriteLine($"{index}");
                    return index;
                }),
            };

            Task.WaitAll(tasks.ToArray());
        }
    }
}
