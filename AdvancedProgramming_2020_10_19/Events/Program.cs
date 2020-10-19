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


            //Beispiel 2: Like a WinForm - Button
            Button b1 = new Button();

            b1.KlickEvent += MeineKlickLogik;
            b1.KlickEvent += Logger;
            b1.Klick();
            //b1.KlickEvent = null;       // absolut verboten
            b1.KlickEvent -= Logger;
            b1.Klick();




            Console.ReadLine();
        }

        private static void Logger()
        {
            Console.WriteLine($"[{DateTime.Now}]: Button wurde geklickt");
        }

        private static void MeineKlickLogik()
        {
            Console.Beep();
            Console.WriteLine("*click*");
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




    class Button
    {
        public event Action KlickEvent;// "AutoProperty"
        public void Klick()
        {
            // Logik
            if (KlickEvent != null)
                KlickEvent();
        }
    }
    
}
