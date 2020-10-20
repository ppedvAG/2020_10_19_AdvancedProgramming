using System;
using System.Threading;

namespace MutexSample
{
    class Program
    {
        //Beispiel 1: Zeigt Mutex auf Programmebene

        private static Mutex mutex = null;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private static void DoSomething()
        {
            mutex = new Mutex(false, "MyMutex");

            bool lockTaken = false;


            try
            {
                lockTaken = mutex.WaitOne();

                //Kritischer Codeblock

            }
            finally
            {
                if (lockTaken == true)
                {
                    mutex.ReleaseMutex();
                }
            }

        }




    }
}
