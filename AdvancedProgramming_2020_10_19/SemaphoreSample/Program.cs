using System;
using System.Threading;

namespace SemaphoreSample
{
    class Program
    {
        


        static void Main(string[] args)
        {
            ClassWithSemaphore test1 = new ClassWithSemaphore();

            for (int i = 1; i <= 100; i++)
                new Thread(test1.DoSomething).Start();


            Console.ReadKey();

        }

        
    }


    class ClassWithSemaphore
    {
        private static Semaphore semaphore = new Semaphore(3, 3);
        private static int _counter = 0;


        public void DoSomething()
        {

            semaphore.WaitOne();

            _counter++;
            Console.WriteLine(_counter);
            Thread.Sleep(50);
            _counter--;

            semaphore.Release(); 
        }
    }
}
