using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Chapter1.Listing_1_29
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockingCollection<string> collection = new BlockingCollection<string>();

            Task readTask = Task.Run(() =>
            {
                foreach (string input in collection.GetConsumingEnumerable())
                {
                    Console.WriteLine($"You've entered: \"{input}\"");
                    Console.Write("enter text: ");
                }
            });

            Task writeTask = Task.Run(() =>
            {
                Console.Write("enter text: ");
                while (true)
                {
                    string input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input)) break;
                    collection.Add(input);
                }
            });

            writeTask.Wait();
        }
    }
}
