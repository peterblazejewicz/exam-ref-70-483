using System;
using System.Threading;

namespace Chapter1.Listing_1_5
{
    class Program
    {

        [ThreadStatic]
        static int field;

        static void Main(string[] args)
        {

            new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    field++;
                    Console.WriteLine($"Thread A: {field}");
                }
            }).Start();

            new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    field++;
                    Console.WriteLine($"Thread B: {field}");
                }
            }).Start();

            Console.ReadKey();

        }
    }
}
