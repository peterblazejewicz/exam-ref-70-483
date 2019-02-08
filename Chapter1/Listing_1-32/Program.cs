using System;
using System.Collections.Concurrent;

namespace Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentStack<int> stack = new ConcurrentStack<int>();

            stack.Push(42);

            int results;
            if (stack.TryPop(out results))
            {
                Console.WriteLine($"Popped: {results}");
            }

            stack.PushRange(new int[] { 1, 2, 3 });

            int[] values = new int[2];
            stack.TryPopRange(values);

            foreach (int i in values)
            {
                Console.WriteLine(i);
            }
        }
    }
}
