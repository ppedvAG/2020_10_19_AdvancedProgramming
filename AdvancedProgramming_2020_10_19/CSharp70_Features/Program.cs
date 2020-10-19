using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace CSharp70_Features
{
    public class Program
    {

        #region Boding Members - Verlürzte Schreibweise
        private DateTime birthday;

        public DateTime Birthday
        {
            get
            {
                return birthday;
            }

            set
            {
                birthday = value;
            }
        }

        public DateTime Birthday1
        {
            get => birthday;
            set => birthday = value;
        }
        #endregion


        static void Main(string[] args)
        {

            #region Out-Variablen
            int intVariable = 5;
            int result = Calculate(3, out intVariable);

            string stringWert = "5";
            int convertedInteger;

            convertedInteger = int.Parse(stringWert); //Hier kann beim konventieren ein Fehler entstehen, wenn der Inhalt nicht valide ist

            if (int.TryParse(stringWert, out convertedInteger))
            {
                //Dieser Code wird ausgeführt, wenn die Variable stringWert einen Integer beinhaltet

                //Das Ergebnis der Konventierung befindet sich convertedInteger

                Console.WriteLine(convertedInteger);
            }

            //Decimal-Datentyp!!!! Info
            //wichtig ist -> decimal wird für Geldbeträge verwendet.

            //Literal: 100_000_000m;
            //Suffix - m wird bei Decimal verwendet. 
            decimal money = 100_000_000m;
            #endregion

            #region PatternMatching

            CheckParameter(123);
            PatternMatchingWithSwichStatement(new Kreis { Durchmesser = 5 });



            #endregion

            #region Verwenden Tupel
            Person person = new Person();
            var result1 = person.GetCompleteName();
            //result1.Item1 -> Vorname
            //result1.Item2 -> Zweiten Vornamen
            //result1.Item3 -> Nachname

            //selbe schreibweise wie bei var result1 -> man verwendet item1, item2, item3
            (string, string, string) result2 = person.GetCompleteName();
            //result2.Item1; result2.Item2; 

            string vorname, nachname, zweiterVorname;

            (vorname, zweiterVorname, nachname) = person.GetCompleteName();

            #endregion


            #region Dekonstruktion von Typen
            Kunde k = new Kunde { Id = 123, Name = "Andre", Stammkunde = true };
            var (id, name, stammkunde) = k;
            Console.WriteLine($"{id}{name}{stammkunde}");

            #endregion


            #region Literale

            int zahl = 1_000_000;
            int hex = 0xFFFFFF; //conventiert Hex->Decimal-System nur als direkte Variablenzuweisung. 


            //Das funktioniert so nicht -> Keine Konventierungen sind möglich
            //string hex1 = "0xFFFFFF";
            //int zahl2 = int.Parse(hex1);


            Console.WriteLine(zahl);


            #endregion

            #region Rückgabe per Referenz

            // Create an array of author names   
            string[] authors = { "Mahesh Chand", "Mike Gold", "Dave McCarter", "Allen O'neill", "Raj Kumar" };


            // Call a method that returns by ref    
            ref string author4 = ref new Program().FindAuthor(3, authors);
            Console.WriteLine("Original author:{0}", author4);

            // Prints 4th author in array = Allen O'neill    
            Console.WriteLine();


            authors = null;
            // Replace 4th author by new author. By Ref, it will update the array    
            author4 = "Chris Sells";


            
            // Print 4th author in array  
            Console.WriteLine("Replaced author:{0}", authors[3]);
            #endregion


            #region Bodied Member

           

            

            #endregion


            Console.ReadKey();
        }


        public ref string FindAuthor(int number, string[] names)
        {

            if (names.Length > 0)
                return ref names[number]; // return the storage location, not the value    
            throw new IndexOutOfRangeException($"{nameof(number)} not found.");

        }

        public static int Calculate(int a, out int b) // Hier wird die Adresse für die Int-Variable 
        {
            b = 11;

            return a * b;
        }

        public static void CheckParameter(object obj)
        {
            if (obj is int intergerVariable)  // Die Gültigkeit der Variable integerVariable gilt nur für das if-statement 
            {
                intergerVariable++;

                Console.WriteLine(intergerVariable);
            }
        }

        public static void CheckParameterAlteVariabnte(object obj)
        {
            if (obj is int)
            {
                int intergerVariable = (int)obj; //Alternativen int.Parse oder Convert.ToInt32

                Console.WriteLine(intergerVariable);
            }
        }


        public static void PatternMatchingWithSwichStatement(Grafik g)
        {
            switch (g)
            {
                case Kreis k:
                    break;
                case Reckteck r when r.Breite == r.Länge && r.Breite > 5:
                    break;

                default:
                    break;
            }


           
        }

    }

    public class Grafik
    {

    }

    public class Reckteck : Grafik
    {
        public int Länge { get; set; }
        public int Breite { get; set; }
    }

    public class Kreis : Grafik
    {
        public int Durchmesser { get; set; }
    }



    public class Person
    {
        private string zweiterVornamen;
        public string ZweiterVornamen
        {
            get => this.zweiterVornamen;


            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Variable muss befüllt sein");
                this.zweiterVornamen = value;
            }
        }

        //Auto-Property
        public string Vorname { get; set; }

        public string Nachname { get; set; }


        //Deconstrutor Objekt wird auf seine Variablen aufgebröselt
        public (string, string, string) GetCompleteName()
        {
            return (Vorname, ZweiterVornamen, Nachname);
        }

        public (string Vorname, string ZweiterVorname, string Nachname) GetCompleteNameWithAlias()
        {
            return (Vorname, ZweiterVornamen, Nachname);
        }
    }

    public class Kunde
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Stammkunde { get; set; }

        public void Deconstruct(out int ID, out string Name, out bool Stammkunde)
        {
            ID = this.Id;
            Name = this.Name;
            Stammkunde = this.Stammkunde;
        }
    }


    public interface IDevice
    {
        string Name { get; set; }


    }

    public class MyDevice : IDevice
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
