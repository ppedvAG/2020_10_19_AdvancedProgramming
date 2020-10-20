using System;

namespace SingletonSampleQ2
{
    //Gibt es alternative Ansätze für die Modellierung von Singleton Entwurfsmuster?

    // Antwort:
    //Es gibt viele Ansätze.Jeder von ihnen hat Vor- und Nachteile.
    //Ich werde einen Ansatz erörtern, der als doppelt geprüftes Sperren bezeichnet wird.
    //MSDN skizziert den Ansatz wie hier gezeigt:
    public sealed class Singleton
    {
        //We are using volatile to ensure that
        //assignment to the instance variable finishes before it’s
        //access.
        private static volatile Singleton instance;
        private static object lockObject = new Object();
        private Singleton() { }
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                            instance = new Singleton();
                    }
                }
                return instance;
            }
        }
    }
}


//Why are you marking the instance as volatile in double
//checked locking example?


//Let’s see what C# specification tells you:
//The volatile keyword indicates that a field might be modified by
//multiple threads that are executing at the same time. Fields that
//are declared volatile are not subject to compiler optimizations that
//assume access by a single thread. This ensures that the most up-todate value is present in the field at all times.
//In simple terms, the volatile keyword can help you to provide
//a serialize access mechanism. In other words, all threads will
//observe the changes by any other thread as per their execution
//order. You will also remember that the volatile keyword is
//applicable for class (or struct) fields; you cannot apply it to local
//variables.
