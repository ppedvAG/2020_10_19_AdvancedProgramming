using System;
using System.Runtime.CompilerServices;

namespace CSharp80_Features
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program.Test(); //Aufruf einer Statischen Lokalen Methode

            Program p = new Program();
            p.Test2(); //Aufruf eine normalen Methode






            //Verbatim String - $
            int variable1 = 123;

            string text1 = "Die Ausgabe der Variable ist: "; //Im Arbeitspeicher wird ein String angelegt mit der länge des zugewiesenen Textes:"Die Ausgabe der Variable ist: "

            string text2 = text1 + variable1.ToString(); //Bad Code! Ein neuer Speicher musst reserviert werden -> Performance Verlust 


            Console.WriteLine(text1 + text2); //Neuer Speicher wird generiert + Werte von alter Speicheradresse in Neue rüberkopiert. 

            Console.WriteLine("{0} {1}", text1, text2); //Alte Schreibvariante mit Anlehnung aus C -> printf Befehl 

            Console.WriteLine($"Das ERgebnis ist {text1} {text2}");


            //@ Zeichen

            string FilePath = @"C:\Program Files\Test"; //Mit @ schaltet man die Escape Zeichen aus, dadurch kann man einfache Daten- oder Verzeichnispfade darstellen. 


        }

        static void Test()
        {
            
        }

        void Test2()
        {

        }

       
    }

    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }


        //Readonly gibt den Member-Variablen einen Schreibschutz
        public readonly void Berrechnen(int offsetX, int offsetY)
        {
            Console.Write(X); //Funktioniert

            offsetY = 0;

            //X += 1; // Gibt einen Fehler aus, weil man versucht die Membervariable X zu überschreiben

        }
    }

    public class LokaleStatischeVariablen // 
    {
        public int classMemberVariable = 0;
        public int Calc(int a, int b)
        {
            
            
            return Add(a, b);

            static int Add(int links, int rechts)
            {
                /*classMemberVariable += 1; */ //statische lokale Funktionen können nicht auf MemberVariablen zugreifen
                return links + rechts;
            }//statische lokale Funktion 
        }

        public int Calc1(int a, int b)
        {
            return Add(a, b);

            int Add(int links, int rechts) //lokale Funktion 
            {
                classMemberVariable += 1;
                return links + rechts;
            }
        }
    }

}
