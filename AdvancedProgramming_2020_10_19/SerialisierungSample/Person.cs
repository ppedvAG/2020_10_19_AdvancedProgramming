using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
using System.Runtime.Serialization;

namespace SerialisierungSample
{
    [Serializable()] //-> Wird nur für binäre Serialisierung verwendet
    public class Person
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public byte Alter { get; set; }

        public decimal Kontostand;
    }




    // A test object that needs to be serialized.
    [Serializable()]
    public class TestSimpleObject
    {

        public int member1;
        public string member2;
        public string member3;
        public double member4;

        // A field that is not serialized.
        [NonSerialized()]
        public string member5;

        public TestSimpleObject()
        {

            member1 = 11;
            member2 = "hello";
            member3 = "hello";
            member4 = 3.14159265;
            member5 = "hello world!";
        }

        public void Print()
        {

            Console.WriteLine("member1 = '{0}'", member1);
            Console.WriteLine("member2 = '{0}'", member2);
            Console.WriteLine("member3 = '{0}'", member3);
            Console.WriteLine("member4 = '{0}'", member4);
            Console.WriteLine("member5 = '{0}'", member5);
        }
    }
}
