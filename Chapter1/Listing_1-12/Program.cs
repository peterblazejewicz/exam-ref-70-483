using System;
using System.Threading.Tasks;

namespace Chapter1.Listing_1_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int[]> parentTask = Task.Run(() =>
            {
                int[] results = new int[3];
                new Task(() => results[0] = 0, TaskCreationOptions.AttachedToParent)
                    .Start();
                new Task(() => results[1] = 1, TaskCreationOptions.AttachedToParent)
                    .Start();
                new Task(() => results[2] = 2, TaskCreationOptions.AttachedToParent)
                    .Start();
                return results;
            });

            Task finalTask = parentTask.ContinueWith(action =>
            {
                foreach (int i in action.Result)
                {
                    Console.WriteLine(i);
                }
            });

            finalTask.Wait();
        }
    }
}
