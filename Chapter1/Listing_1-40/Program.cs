using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1.Listing_1_40
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            Task task = Task.Run(() =>
            {
                for (int i = 0; i < 1_000_000; i++)
                {
                    Interlocked.Increment(ref n);
                }
            });

            for (int i = 0; i < 1_000_000; i++)
            {
                Interlocked.Decrement(ref n);
            }

            task.Wait();
            Console.WriteLine(n);
        }
    }
}
