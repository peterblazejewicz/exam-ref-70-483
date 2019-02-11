using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter1.Listing_1_23
{
    class Program
    {
        static void Main(string[] args)
        {

            IEnumerable<int> numbers = Enumerable.Range(0, 10);
            int[] parallelResults = numbers.AsParallel()
                .WithExecutionMode(ParallelExecutionMode.ForceParallelism)
                .WithDegreeOfParallelism(4)
                .Where(i => i % 2 == 0)
                .ToArray();

            foreach (int i in parallelResults)
            {
                Console.WriteLine(i);
            }
        }
    }
}
