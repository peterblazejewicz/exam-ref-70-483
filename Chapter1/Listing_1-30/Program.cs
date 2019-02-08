using System;
using System.Collections.Concurrent;

namespace Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();
            bag.Add(42);
            bag.Add(21);

            int results;
            if (bag.TryTake(out results))
            {
                Console.WriteLine(results);
            }
            if (bag.TryPeek(out results))
            {
                Console.WriteLine($"There is a next item: {results}");
            }
        }
    }
}
