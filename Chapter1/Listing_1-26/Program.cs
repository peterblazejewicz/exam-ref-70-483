using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> numbers = Enumerable.Range(0, 20);

            ParallelQuery<int> parallelResults = numbers
                .AsParallel()
                .Where(i => i % 2 == 0);

            parallelResults.ForAll(i => Console.WriteLine(i));
        }
    }
}
