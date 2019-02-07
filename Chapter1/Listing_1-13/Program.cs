using System;
using System.Threading.Tasks;

namespace Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int[]> parentTask = Task.Run(() =>
            {
                int[] results = new int[3];

                TaskFactory taskFactory = new TaskFactory(
                    TaskCreationOptions.AttachedToParent,
                    TaskContinuationOptions.ExecuteSynchronously
                );
                taskFactory.StartNew(() => results[0] = 0);
                taskFactory.StartNew(() => results[1] = 1);
                taskFactory.StartNew(() => results[2] = 2);

                return results;
            });

            Task finalTask = parentTask.ContinueWith(parent =>
            {
                foreach (int i in parent.Result)
                {
                    Console.WriteLine($"{i}");
                }
            });
            finalTask.Wait();
        }
    }
}
