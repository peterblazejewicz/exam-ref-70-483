using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Chapter1.Listing_1_28
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockingCollection<string> collection = new BlockingCollection<string>();

            Task readTask = Task.Run(() =>
            {
                while (true)
                {
                    string input = collection.Take();
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
