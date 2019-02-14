using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1.Listing_1_43
{
    class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = cancellationTokenSource.Token;
            Task task = Task.Run(() =>
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    Console.WriteLine("*");
                    Thread.Sleep(1_000);
                }
                cancellationToken.ThrowIfCancellationRequested();
            }, cancellationToken);

            try
            {
                Console.WriteLine("Press Enter to stop task");
                Console.ReadLine();
                cancellationTokenSource.Cancel();
                task.Wait();
            }
            catch (AggregateException ex)
            {
                Console.WriteLine(ex.InnerExceptions.First().Message);
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
