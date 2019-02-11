using System;
using System.Collections.Concurrent;

namespace Chapter1.Listing_1_33
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentQueue<int> queue = new ConcurrentQueue<int>();
            queue.Enqueue(42);

            int results;
            if (queue.TryDequeue(out results))
            {
                Console.WriteLine($"Dequeued: {results}");
            }
        }
    }
}
