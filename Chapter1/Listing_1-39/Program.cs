using System;
using System.Threading;

namespace Chapter1.Listing_1_39
{
    class Program
    {

        static volatile int _flag = 0;
        static int _value = 0;

        static void Thread1()
        {
            _value = 5;
            _flag = 1;
        }

        static void Thread2()
        {
            if (_flag == 1)
            {
                Console.WriteLine(_value);
            }
        }
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(Thread1);
            Thread thread2 = new Thread(Thread2);
            thread1.Start();
            thread2.Start();
        }
    }
}
