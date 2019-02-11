using System;
using System.Threading.Tasks;

namespace Chapter1.Listing_1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task = Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("*");
                }
            });

            task.Wait();
        }
    }
}
