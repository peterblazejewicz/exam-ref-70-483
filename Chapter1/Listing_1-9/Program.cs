using System;
using System.Threading.Tasks;

namespace Chapter1.Listing_1_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> task = Task.Run(() => 42);

            Console.WriteLine($"Results: {task.Result}");
        }
    }
}
