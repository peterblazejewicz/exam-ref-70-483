using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1.Listing_1_16
{
    class Program
    {
        static void Main(string[] args)
        {

            Parallel.For(0, 10, i =>
            {
                Console.WriteLine($"For: {i}");
                Thread.Sleep(1000);
            });

            IEnumerable<int> numbers = Enumerable.Range(0, 10);
            Parallel.ForEach(numbers, i =>
            {
                Console.WriteLine($"ForEach: {i}");
                Thread.Sleep(1000);
            });

        }
    }
}
