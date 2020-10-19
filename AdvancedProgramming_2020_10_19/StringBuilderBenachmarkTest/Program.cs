using System;
using System.Diagnostics;
using System.Text;

namespace StringBuilderBenachmarkTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string aufbauenderString = string.Empty;

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            for( int i=0; i < 10000; i++)
            {
                aufbauenderString += i.ToString();
            }
            //Console.Write(aufbauenderString);
            stopwatch.Stop();

            long testErgebnis1 = stopwatch.ElapsedMilliseconds;

            Console.WriteLine("Taste drücken......");
            Console.ReadKey();

            StringBuilder sb = new StringBuilder();

            Stopwatch stopwatch1 = new Stopwatch();

            stopwatch1.Start();

            for (int i = 0; i < 10000; i++)
            {
                sb.Append(i);
            }

            //Console.Write(sb.ToString());
            //Auslesen eines StringBuilder 

            stopwatch1.Stop();

            long testErgebnis2 = stopwatch1.ElapsedMilliseconds;

            Console.WriteLine("Benchmark Ergebnis");
            Console.WriteLine($"einfaches addieren von Strings - Zeit: {testErgebnis1}");
            Console.WriteLine($"Arbeiten mit StringBuilder - Zeit: {testErgebnis2}");
            Console.ReadLine();
        }
    }
}
