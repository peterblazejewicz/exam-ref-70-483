using System;
using System.Threading.Tasks;

namespace Chapter1.Listing_1_35
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            Task task = Task.Run(() =>
            {
                for (int i = 0; i < 1_000_000; i++)
                {
                    n++;
                }
            });
            for (int i = 0; i < 1_000_000; i++)
            {
                n--;
            }

            task.Wait();
            Console.WriteLine(n);
        }
    }
}
