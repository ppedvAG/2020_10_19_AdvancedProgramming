using System;
using System.Threading.Tasks;

namespace Async_Await_With_ReturnValues
{
    class Program
    {
        static void Main(string[] args)
        {
            callMethode();

            Console.ReadKey();
        }

        private static async void callMethode()
        {
            //So wird das mit TPL gemacht
            Task<int> task1 = new Task<int>(Methode1a);
            task1.Wait();
            Console.WriteLine(task1.Result.ToString());

            //Async Await Pattern
            Task<int> task = Methode1();
            int count = await task; //Hier wird das Ergebnis des Task zurück gegeben

            //Synchrone Methode...
            Methode2();

            Method3(count);
        }



        private static async Task<int> Methode1()
        {
            int count = 0;

            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(" Methode 1");
                    count += 1;

                }
            });

            return count;
        }


        private static int Methode1a()
        {
            int count = 0;

            Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(" Methode 1");
                    count += 1;

                }
            });

            return count;
        }

        //Synchrone Beispiel Methode ohne Async
        public static void Methode2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(" Methode 2");
            }
        }

        public static void Method3(int count)
        {
            Console.WriteLine("Total count is " + count);
        }
    }
}
