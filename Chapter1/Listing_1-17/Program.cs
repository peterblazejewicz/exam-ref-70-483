using System;
using System.Threading.Tasks;

namespace Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {

            ParallelLoopResult results = Parallel.For(0, 1000, (int i, ParallelLoopState state) =>
            {
                if (i == 500)
                {
                    Console.WriteLine("Breaking loop");
                    state.Break();
                }
                return;
            });

            Console.WriteLine($"results.IsCompleted: {results.IsCompleted}");
            Console.WriteLine($"results.LowestBreakIteration: {results.LowestBreakIteration}");
        }
    }
}
