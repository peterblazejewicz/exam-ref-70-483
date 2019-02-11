using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1.Listing_1_37
{
    class Program
    {
        static void Main(string[] args)
        {

            object lockA = new object();
            object lockB = new object();

            Task task = Task.Run(() =>
            {
                Console.WriteLine("Lock A");
                lock (lockA)
                {
                    Console.WriteLine($"Sleep {1_000}");
                    Thread.Sleep(1_000);
                    lock (lockB)
                    {
                        Console.WriteLine("Lock B");
                    }
                }
            });

            Console.WriteLine("Lock B");
            lock (lockB)
            {
                Console.WriteLine($"Sleep {1_000}");
                Thread.Sleep(1_000);
                lock (lockA)
                {
                    Console.WriteLine("Lock A");
                }
            }

            task.Wait();

        }
    }
}
