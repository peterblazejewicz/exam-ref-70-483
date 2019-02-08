using System;
using System.Collections.Concurrent;

namespace Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentDictionary<string, int> dict = new ConcurrentDictionary<string, int>();
            if (dict.TryAdd("k1", 42))
            {
                Console.WriteLine("Added");
            }

            if (dict.TryUpdate("k1", 21, 42))
            {
                Console.WriteLine("42 updated to 21");
            }

            // override uncoditionally
            dict["k1"] = 42;

            int r1 = dict.AddOrUpdate("k1", 3, (key, value) => value * 2);
            int r2 = dict.GetOrAdd("k2", 3);

            Console.WriteLine($"Value of k1: {r1}");
            Console.WriteLine($"Value of k2: {r2}");
        }
    }
}
