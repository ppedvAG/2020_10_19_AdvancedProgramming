using System;
using System.Collections.Generic;
using System.Text;

namespace EventHandlerSample
{

    public delegate void Notiy(); //delegate

    public class ProcessBusinessLogic
    {
        public event Notiy ProcessCompledet; //Event

        public void StartProcess()
        {

            // Mach was ..... 
            Console.WriteLine("Process Started!");
            OnProcessCompleted();
        }

        private void OnProcessCompleted()
        {
            ProcessCompledet?.Invoke();
        }
    }


    








}
