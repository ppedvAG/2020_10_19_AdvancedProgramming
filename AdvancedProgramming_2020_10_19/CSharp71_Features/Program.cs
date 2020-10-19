using System;

namespace CSharp71_Features
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //Optionale Literale
            OptionaleParameter();
        }


        private static void OptionaleParameter(int i=default) //Optionaler Parameter -> Methodenaufruf kann auch so ausschauen -> OptionaleParameter();
        {
            Console.WriteLine(i);
        }
    }
}
