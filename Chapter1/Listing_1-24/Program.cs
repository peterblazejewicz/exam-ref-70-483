using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter1.Listing_1_24
{
    class Program
    {
        static void Main(string[] args)
        {

            IEnumerable<int> numbers = Enumerable.Range(0, 10);
            int[] parallelResults = numbers.AsParallel()
                // enforces sorted results
                .AsOrdered()
                // enforces parallelism
                .WithExecutionMode(ParallelExecutionMode.ForceParallelism)
                // sets max cores
                .WithDegreeOfParallelism(8)
                .Where(i => i % 2 == 0)
                .ToArray();

            foreach (int i in parallelResults)
            {
                Console.WriteLine(i);
            }
        }
    }
}
