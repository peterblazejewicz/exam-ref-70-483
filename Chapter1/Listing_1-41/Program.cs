using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chatper1.Listing_1_41
{
    class Program
    {

        static int value = 1;
        static void Main(string[] args)
        {
            Task task1 = Task.Run(() =>
            {
                // Interlocked.CompareExchange(ref value, 2, 1);
                if (value == 1)
                {
                    // Removing the following line will change the output
                    Thread.Sleep(1_000);
                    value = 2;
                }
            });

            Task task2 = Task.Run(() =>
            {
                Thread.Sleep(500);
                value = 3;
            });

            Task.WaitAll(task1, task2);
            Console.WriteLine(value);

        }
    }
}
