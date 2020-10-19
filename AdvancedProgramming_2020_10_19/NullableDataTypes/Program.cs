using System;

namespace NullableDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int? index = null; //Nullable Typen stehen für Defensives Programmieren 

            index = 2;


            if (index.HasValue)
            {
                Console.WriteLine(index.Value);
            }
            else
                Console.WriteLine("Variable wurde nicht initialisiert");

            DateTime? dateTime = null; 

            Console.ReadKey();
        }
    }
}
