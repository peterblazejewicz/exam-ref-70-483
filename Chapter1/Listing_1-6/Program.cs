using System;
using System.Threading;

namespace Chapter1
{
    class Program
    {

        static ThreadLocal<int> field = new ThreadLocal<int>(
            () => Thread.CurrentThread.ManagedThreadId);

        static void Main(string[] args)
        {
            new Thread(() =>
            {
                for (int i = 0; i < field.Value; i++)
                {
                    Console.WriteLine($"Thread A: {i}");
                }
            }).Start();

            new Thread(() =>
            {
                for (int i = 0; i < field.Value; i++)
                {
                    Console.WriteLine($"Thread B: {i}");
                }
            }).Start();

            Console.ReadKey();
        }
    }
}
