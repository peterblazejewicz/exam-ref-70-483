using System;
using System.Threading.Tasks;

namespace Chapter1.Listing_1_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> task = Task.Run(() => 42)
                .ContinueWith(action => action.Result * 2);
            task.ContinueWith(
                action => Console.WriteLine("Cancelled"),
                TaskContinuationOptions.OnlyOnCanceled)
                .ContinueWith(
                    action => Console.WriteLine("Faulted"),
                    TaskContinuationOptions.OnlyOnFaulted);
            Task completionTask = task.ContinueWith(
                action => Console.WriteLine("Completed"),
                TaskContinuationOptions.OnlyOnRanToCompletion
            );
            completionTask.Wait();
        }
    }
}
