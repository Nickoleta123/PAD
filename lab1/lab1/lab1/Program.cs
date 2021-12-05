using System;

namespace lab1
{
    public class Program
    {
        public static void Main()
        {
            var t1 = new MyThread("Thread 1", GetRandomNumber(3000));
            var t2 = new MyThread("Thread 2", GetRandomNumber(3000));
            var t3 = new MyThread("Thread 3", GetRandomNumber(3000));
            var t4 = new MyThread("Thread 4", GetRandomNumber(3000));
            var t5 = new MyThread("Thread 5", GetRandomNumber(3000));
            var t6 = new MyThread("Thread 6", GetRandomNumber(3000));
            var t7 = new MyThread("Thread 7", GetRandomNumber(3000));

            t5.WaitFor(t1, t2);
            t6.WaitFor(t3, t4);
            t7.WaitFor(t5, t6);
            

            MyThread[] threads = { t1, t2, t3, t4, t5, t6, t7 };

            foreach (var thread in threads) thread.Start();
        }

        private static int GetRandomNumber(int max) => new Random().Next(max);
    }
}
