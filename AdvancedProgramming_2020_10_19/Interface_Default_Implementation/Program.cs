using System;

namespace Interface_Default_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {

            IMyTestInterface myTestInterface = new MyTestClass();

            MyTestClass myTestClass = new MyTestClass();

            myTestInterface.InterfaceDefaultMethode(); //Welche InterfaceDefaultMethode wird aufgerufen

            myTestClass.InterfaceDefaultMethode(); //Welche InterfaceDefaultMethode wird aufgerufen



            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }


    public interface IMyTestInterface
    {
        void InterfaceDefaultMethode ()
        {
            Console.WriteLine("Interface Implementierung");
        }

        void KlassicheInterfaceMethode();
    }

    public class MyTestClass : IMyTestInterface
    {

        //void IMyTestInterface.InterfaceDefaultMethode()
        //{
        //    Console.WriteLine("Implementierung aus der MyTestClass");
        //}


        /// <summary>
        /// Interface-Methode wird quasi überschrieben.
        /// </summary>
        public void InterfaceDefaultMethode()
        {
            Console.WriteLine("Implememntierung aus der Klasse");
        }

        public void KlassicheInterfaceMethode()
        {
            throw new NotImplementedException();
        }
    }
}
