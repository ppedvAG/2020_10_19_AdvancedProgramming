using System;
using System.Threading;

namespace MonitorSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        //Monitor funktioniert genauso, wie Lock. Lock wird vorgezogen
        static void KritischerCodeAbschnitt()
        {
            
            try
            {
                int x = 1;

                //if (Monitor.TryEnter(x))
                //{
                //  Monitor.Exit(x);
                //}
                Monitor.Enter(x); //Codeabschnitt wird vom ersten Thread gesperrt

                try
                {
                    //Kritischer Bereich zum Berarbeiten. 
                    //Z.b Funktionen wie Konto abheben und einzahlen
                }
                finally
                {
                    Monitor.Exit(x);
                }
            }
            catch(SynchronizationLockException syncEx)
            {
                Console.WriteLine(syncEx.Message);
            }
        }
    }
}
