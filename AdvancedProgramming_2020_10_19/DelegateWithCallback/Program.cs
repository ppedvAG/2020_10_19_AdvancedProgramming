using System;

namespace DelegateWithCallback
{
    class Program
    {
        public delegate void Del(string message);

        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }

        public static void MethodWithCallback(int param1, int param2, Del callback)
        {
            //Mach was mit Param1 und Param2 
            //Dauert ein wenig Zeit



            //Ganz am Ende wird der Callback ausgelöst 
            callback("The number is: " + (param1 + param2).ToString());
        }

        static void Main(string[] args)
        {
            Del handler = DelegateMethod;
            handler("Hello World"); //Ruft public static void DelegateMethod(string message) Methode auf! 


            MethodWithCallback(1, 2, handler);


            Console.ReadKey();
        }
    }
}
