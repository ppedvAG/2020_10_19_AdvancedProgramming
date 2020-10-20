using System;
using System.Threading;
using System.Threading.Tasks;

namespace _004_TaskBeenden
{
    class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cts = new CancellationTokenSource();

            Task task = Task.Factory.StartNew(MeineMethodeMitAbbrechen, cts);
            Thread.Sleep(10000);
            Console.WriteLine("Jetzt wird der Task geschlossen:");
            cts.Cancel();


            Console.WriteLine("Hello World!");

            Console.ReadKey();
        }

        private static void MeineMethodeMitAbbrechen(object param)
        {
            CancellationTokenSource source = (CancellationTokenSource)param;

            while (true)
            {
                Console.WriteLine("zzz......zzzzz");
                Thread.Sleep(50);

                if (source.IsCancellationRequested)
                    break;
            }
        }
    }
}
