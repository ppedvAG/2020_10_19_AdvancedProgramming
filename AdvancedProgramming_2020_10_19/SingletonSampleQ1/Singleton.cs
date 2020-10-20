using System;

namespace SingletonSampleQ1
{
    //Singleton mit Fehlerpotential und beschränkten Einsatz
    public class Singleton
    {
        private static Singleton instance;
        private Singleton() { }
        public static Singleton Instance
        {
            get
            {
                //Achtung bei Multi-Threading 
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}


// Dieser Ansatz kann in einer Single-Thread-Umgebung funktionieren. 
// Ziehen Sie jedoch eine Multithreading-Umgebung in Betracht.
// In einer Multithreading-Umgebung wird angenommen, dass zwei (oder mehr) Threads versuchen, dies auszuwerten:
// if (instance == null)
// Wenn sie sehen, dass die Instanz noch nicht erstellt wurde, wird jeder Thread versuchen, eine neue Instanz zu erstellen. 
// Als Ergebnis erhalten Sie möglicherweise mehrere Instanzen der Klasse.