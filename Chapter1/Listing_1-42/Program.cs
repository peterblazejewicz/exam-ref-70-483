using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1.Listing_1_42
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
            }, cancellationToken);

            Console.WriteLine("Press Enter to stop task");
            Console.ReadLine();
            cancellationTokenSource.Cancel();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
