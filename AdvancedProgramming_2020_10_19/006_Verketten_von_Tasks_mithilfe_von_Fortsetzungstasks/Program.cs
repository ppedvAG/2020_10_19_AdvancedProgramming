using System;
using System.Threading.Tasks;

namespace _006_Verketten_von_Tasks_mithilfe_von_Fortsetzungstasks
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            Task<DayOfWeek> taskA = Task.Run(() => DateTime.Today.DayOfWeek);
            //Task<DayOfWeek> taskAlternativ = Task.Run(WhatDayIsToday)
            ;
            await taskA.ContinueWith(antecedent => Console.WriteLine($"Today is {antecedent.Result}."));

            Console.WriteLine("Alles soweit fertig!");

            Console.ReadKey();
        }


        public static DayOfWeek WhatDayIsToday()
        {
            return DateTime.Today.DayOfWeek;
        }
    }
}
