using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {

            Task<int>[] tasks = new Task<int>[]{
                Task.Run(() => {
                    Thread.Sleep(2000);
                    return 1;
                }),
                Task.Run(() => {
                    Thread.Sleep(1000);
                    return 2;
                }),
                Task.Run(() => {
                    Thread.Sleep(3000);
                    return 3;
                }),
            };

            while (tasks.Length > 0)
            {
                int index = Task.WaitAny(tasks);
                Task<int> completedTask = tasks[index];

                Console.WriteLine(completedTask.Result);

                List<Task<int>> temp = tasks.ToList();
                temp.RemoveAt(index);

                tasks = temp.ToArray();
            }
        }
    }
}
