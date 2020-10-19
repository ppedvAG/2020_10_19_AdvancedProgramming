﻿using System;

namespace DelegateEvent_And_EventHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessBusinessLogic2 bl2 = new ProcessBusinessLogic2();
            bl2.ProcessCompleted += Bl2_ProcessCompleted;
            bl2.ProcessCompletedNew += Bl2_ProcessCompletedNew;

            bl2.StartProcess();
        }

        private static void Bl2_ProcessCompletedNew(object sender, EventArgs e)
        {
            MyEventArg myEventArg = (MyEventArg)e;

            Console.WriteLine($"Fertig am {myEventArg.Uhrzeit.ToString()}");
        }

        private static void Bl2_ProcessCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Process Completed!");
        }
    }
}
