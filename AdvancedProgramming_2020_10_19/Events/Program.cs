using System;

namespace Events
{

    public delegate void MyEventHandler();
    class Program
    {


        public static event MyEventHandler _show;



        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            _show += new MyEventHandler(Cat);
            _show += new MyEventHandler(Dog);
            _show += new MyEventHandler(Mouse);
            _show += new MyEventHandler(Mouse);

            _show.Invoke(); //Aufrufen der drangehängten Methoden 
        }

        static void Cat()
        {
            Console.WriteLine("Cat");
        }

        static void Dog()
        {
            Console.WriteLine("Dog");
        }

        static void Mouse()
        {
            Console.WriteLine("Mouse");
        }
    }
}
