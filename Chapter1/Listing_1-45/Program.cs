using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chatper1.Listing_1_45
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task = Task.Run(() =>
            {
                Thread.Sleep(10_000);
            });

            int status = Task.WaitAny(new[] { task }, 1_000);

            if (status == -1)
            {
                Console.WriteLine("Task timed out");
            }
        }
    }
}
