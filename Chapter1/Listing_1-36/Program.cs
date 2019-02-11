using System;
using System.Threading.Tasks;

namespace Chapter1.Listing_1_36
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            object _lock = new { };

            Task task = Task.Run(() =>
            {
                for (int i = 0; i < 1_000_000; i++)
                {
                    lock (_lock)
                    {
                        n++;
                    }
                }
            });

            for (int i = 0; i < 1_000_000; i++)
            {
                lock (_lock)
                {
                    n--;
                }
            }

            task.Wait();
            Console.WriteLine(n);
        }
    }
}
