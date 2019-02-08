using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IEnumerable<int> numbers = Enumerable.Range(0, 20);
                ParallelQuery<int> parallelResults = numbers
                    .AsParallel()
                    .Where(i => IsEven(i));
                parallelResults.ForAll(i => Console.WriteLine(i));
            }
            catch (AggregateException ex)
            {
                Console.WriteLine($"There were {ex.InnerExceptions.Count} exceptions");
            }
        }

        private static bool IsEven(int i)
        {
            if (i % 10 == 0)
            {
                throw new ArgumentException(nameof(i));
            }
            return i % 2 == 0;
        }
    }
}
