using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IList<string> stringListe = new List<string>();


            DataStore<string> store = new DataStore<string>();


            store.Data = "Hallo Welt";

            DataStore<string> cities = new DataStore<string>();
            cities.AddOrUpdate(0, "Mubmai");
            cities.AddOrUpdate(1, "Chicago");
            cities.AddOrUpdate(2, "London");


            string currentCity = cities.GetData(2);


            IDictionary<Guid, Person> personDictionary = new Dictionary<Guid, Person>(); // BTW: Bessere Variante als HashTable


            Console.ReadKey();
        }
    }
    public class Person
    {
        public int Age { get; set; }
    }

    class DataStore <T>
    {
        public T Data { get; set; }

        public T[] _data = new T[10];


        public void AddOrUpdate(int index, T item)
        {
            if (index >= 0 && index < 10)
                _data[index] = item;
        }

        public T GetData (int index)
        {
            if (index >= 0 && index < 10)
                return _data[index];
            else
                return default(T);
        }

        public void DisplayDefaultOf<T>()
        {
            var val = default(T);

            Console.WriteLine($"Default value of {typeof(T)} is {(val == null ? "null" : val.ToString())}.");
        }
    }


    class Printer
    {
        public void Print<T>(T data)
        {
            Console.WriteLine(data); // ToString wird aufgerufen 
        }
    }

    public class MyKeyValuePair<TKey, TValue, TIchWillAuch>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }

        public TIchWillAuch WeiteresValue { get; set; }
    }


}
