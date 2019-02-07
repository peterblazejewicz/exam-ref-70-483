using System;
using System.Threading;

namespace Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxThreads;
            int minThreads;
            int completionPortThreads;
            ThreadPool.GetMaxThreads(out maxThreads, out completionPortThreads);
            ThreadPool.GetMinThreads(out minThreads, out completionPortThreads);
            Console.WriteLine($"ThreadPool max threads: {maxThreads}");
            Console.WriteLine($"ThreadPool min threads: {minThreads}");

            ThreadPool.QueueUserWorkItem(o =>
            {
                Console.WriteLine("Working on a thread from threadpool");
            });

            Console.ReadLine();
        }
    }
}
