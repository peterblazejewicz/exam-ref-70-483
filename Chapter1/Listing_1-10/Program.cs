using System;
using System.Threading.Tasks;

namespace Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> task = Task.Run(() => 42)
            .ContinueWith(action => action.Result * 2);

            Console.WriteLine($"Results: {task.Result}");
        }
    }
}
