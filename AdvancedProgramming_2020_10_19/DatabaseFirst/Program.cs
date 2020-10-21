using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {

            IList<Person> resultList = new List<Person>();


            using (AdventureWorks2017Entities ctx = new AdventureWorks2017Entities())
            {
                resultList = ctx.Person.ToList(); //Auslesen der Tabelle Personen
            }

            //Ausgelesenes Ergebnis wird präsentiert
            foreach (Person currentPerson in resultList)
            {
                Console.WriteLine($"{currentPerson.rowguid} {currentPerson.FirstName} {currentPerson.LastName}");
            }


            Person newPerson = new Person();
            newPerson.rowguid = Guid.NewGuid();
            newPerson.FirstName = "Max";
            newPerson.LastName = "Mustermann";
            //......


            //Absspeichern
            using (AdventureWorks2017Entities ctx = new AdventureWorks2017Entities()) //EF hat das Pattern UnitOfWork implementiert und man könnte Offline Anwendungen auch schreiben
            {
                ctx.Person.Add(newPerson);


                ctx.SaveChanges(); // Hier erst wird der SQL Insert-Befehl generiert. 
            }



            Console.ReadKey();
        }
    }
}
