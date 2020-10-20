using System;
using System.Threading.Tasks;
using System.Threading;

namespace _001_EinfacherTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Task easyTask = new Task(IchMacheEtwasImTask);
            easyTask.Start();
            easyTask.Wait(); //thread.join(); 

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                Console.Write("*");
            }

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
