using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter1.Listing_1_25
{
    class Program
    {
        static void Main(string[] args)
        {

            IEnumerable<int> numbers = Enumerable.Range(0, 20);
            IEnumerable<int> parallelResults = numbers
                .AsParallel()
                .AsOrdered()
                .WithExecutionMode(ParallelExecutionMode.ForceParallelism)
                .Where(i => i % 2 == 0)
                // stops parallelism here
                .AsSequential();

            // should print 0, 2, 4, 6, 8
            Console.WriteLine("###################");
            Console.WriteLine("First 5 results:");
            Console.WriteLine("###################");
            foreach (int i in parallelResults.Take(5))
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n###################");
            // should print 10, 12, 14, 16, 18
            Console.WriteLine("Last 5 results:");
            Console.WriteLine("###################");
            foreach (int i in parallelResults.Skip(5))
            {
                Console.WriteLine(i);
            }

        }
    }
}
