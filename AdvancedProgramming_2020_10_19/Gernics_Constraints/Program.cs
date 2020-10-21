using System;
using System.Collections;

namespace Gernics_Constraints
{
    class Program
    {
        static void Main(string[] args)
        {

            //class DataStore<T> where T : class //Referenztypen
            DataStore<string> store1 = new DataStore<string>();
            DataStore<MyClass> store2 = new DataStore<MyClass>();
            DataStore<IMyInterface> store3 = new DataStore<IMyInterface>();
            //DataStore<MyStruct> store4 = new DataStore<MyStruct>(); -> nicht valide
            //DataStore<int> store5 = new DataStore<int>(); // ->nicht valide
            DataStore<ArrayList> store5 = new DataStore<ArrayList>();


            //class DataStore1<T> where T : struct //Wertetypen 

            //DataStore1<string> store1 = new DataStore1<string>(); nicht valide
            //DataStore1<MyClass> store2 = new DataStore1<MyClass>();nicht valide
            //DataStore1<IMyInterface> store3 = new DataStore1<IMyInterface>();
            DataStore1<MyStruct> store6 = new DataStore1<MyStruct>(); 
            DataStore1<int> store7 = new DataStore1<int>(); // 
                                                            //DataStore1<ArrayList> store5 = new DataStore1<ArrayList>(); -> nicht valide


            //class DataStore2<T> where T : Animal
            DataStore2<Animal> dataStore2 = new DataStore2<Animal>();
            DataStore2<Dog> dataStore2b = new DataStore2<Dog>();
        }
    }


    class DataStore<T> where T : class 
    {
        public T Data { get; set; }
    }

    class DataStore1<T> where T : struct
    {
        public T Data { get; set; }
    }

    class DataStore2<T> where T : Animal
    {
        public T Data { get; set; }
    }



    class MyClass
    {

    }

    internal interface IMyInterface
    {
    }

    struct MyStruct
    {
        string Name { get; set; }
    }


    public class Animal
    {
        public string Name { get; set; } = "R2D2";
    }

    public class Dog : Animal
    {
        public string Hunderasse { get; set; } = "Schäferhund";
    }
}
