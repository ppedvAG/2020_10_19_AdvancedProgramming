using System;
using System.Threading;
using System.Threading.Tasks;

namespace _002_TaskFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task = Task.Factory.StartNew(IchMacheEtwasImTask);

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                Console.Write("*");
            }



            //Alternative zur Factory.StartNew
            Console.ReadKey();

            Task task2 = Task.Run(IchMacheEtwasImTask); // Im Hintergrund wird die  -> Task.Factory.StartNew(IchMacheEtwasImTask); aufgerufen

            Console.ReadKey();
        }

        private static void IchMacheEtwasImTask()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                Console.Write("#");
            }
        }
    }
}
