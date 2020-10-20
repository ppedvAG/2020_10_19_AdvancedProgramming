using System;
using System.Threading;

namespace _002_ParameterizedThread
{
    class Program
    {
        static void Main(string[] args)
        {
            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(MachEtwasInEinemThreadMitParameter); 

            Thread thread = new Thread(parameterizedThreadStart);

            thread.Start(33);
            thread.Join();

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }


        private static void MachEtwasInEinemThreadMitParameter(object obj)
        {
            for (int i = 0; i < (int)obj; i++)
            {
                //Thread.Sleep(500);
                Console.Write("#");
            }
        }
    }
}
