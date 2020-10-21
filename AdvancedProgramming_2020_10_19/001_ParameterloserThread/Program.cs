using System;
using System.Threading;

namespace _001_ParameterloserThread
{
    class Program
    {
        static void Main(string[] args)
        {
            //using System.Threading;
            Thread thread = new Thread(IchMacheEtwasImThread); //Thread wird initialisiert

            thread.Start(); //Thread wird gestartet 

            //Optionale Einstellung
            thread.IsBackground = true; // thread.IsBackground = true (nennt Background Thread): Wenn Parent-Thread geschlossen wird, werden alle Child-Threads abgebrochen

                                        // thread.IsBackground = false (nennt Background Thread): Wenn Parent-Thread geschlossen wird, arbeiten alle Child-Threads ihre Aufgabe noch ab.
            
            thread.Join(); //Wir warten, bis der Thread fertig ist
            thread.Abort(); //Thread wird abgebrochen. 

            Console.WriteLine("Hello World!");

            for (int i = 0; i < 100; i++)
            {
                
                Console.WriteLine("+");
            }


            Console.ReadKey();
        }

        private static void IchMacheEtwasImThread()
        {
            
            for (int i = 0; i <100; i++)
            {
                Console.WriteLine("#");
            }
        }
    }
}
