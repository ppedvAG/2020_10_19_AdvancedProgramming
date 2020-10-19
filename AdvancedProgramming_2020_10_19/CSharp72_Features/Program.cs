using System;
using CSharp72_Features;

namespace CSharp72_Features
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahlDesTages = 33;

            ChangeValue(out zahlDesTages);

        }


        #region out - ref - in 
        static void ChangeValue(out int myVar)
        {
            myVar = 123; // out MUSS unbedingt eine Zuweisung bekommen
        }


        //Ref kann keine Zuweisungen erlauben, weil es readonly ist
        //static void ChangeValue(ref int myVar)
        //{
        //    myVar = 123; // hier würde ein Fehler bringen
        //}

        static void ReadValue(int myVar) //Hier reservierst man eine neuen Speicherplatz für den Parameter myVar. 
        {

            Console.WriteLine(myVar);
        }

        //Richtiger Einsatz von Ref -> Hier verwendest du den Speicherplatz von zahlDesTages
        static void ReadValue(ref int myVar)
        {
            myVar = 34; //Ref ist frei.. du KANNST es überschreiben
            Console.WriteLine(myVar);
        }


        //static void ReadValueWithIn(in int myVar) //in 
        //{
        //    myVar = 123; //FEhler -> myVar ist nur readonly -> wegen in int myVar
        //}

        #endregion

       
    }



    #region private protected & other modifier 


    ///https://docs.microsoft.com/de-de/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers 

    public class MyClass
    {
        public void GetPublic() { }
        private void GetPrivate() { }
        internal void GetInternal() { }
        protected void GetProtected() { }
        protected internal void GetProtectedInternal() { }
        protected private void GetPrivateProtected() { }

        private protected void GetPrivateProtected1() { }
    }


    public class YourClass : MyClass
    {
        MyClass mc = new MyClass();
        public void Show()
        {
            mc.GetPublic();
            //mc.GetPrivate(); Not accessible as private members of a class are not accessible outside class.  
            mc.GetInternal();
            //mc.GetProtected(); Not accessible as protected members can be accessed only through inheritance and not by creating an object.  
            mc.GetProtectedInternal();
            //mc.GetPrivateProtected(); Not accessible as Private Protected members can be accessed only through inheritance in same assembly.                




            GetPublic();
            //GetPrivate(); Not accessible as private members of a class are not accessible outside class.  
            GetInternal();
            GetProtected();
            GetProtectedInternal();
            GetPrivateProtected();

            GetPrivateProtected1();
        }
    }
    #endregion
}



//Outside the assembly  

namespace ClassLibrary1
{
    public class YourClass1 : CSharp72_Features.MyClass
    {
        MyClass mc = new MyClass();
        public void show()
        {
            mc.GetPublic();
            //mc.GetPrivate(); Not accessible as private members of a class are not accessible outside class.  
            mc.GetInternal(); //Not accessible as internal members are not accessible outside it's assembly.  
            //mc.GetProtected(); Not accessible as protected members can be accessed only through inheritance and not by creating an object.  
            //mc.GetProtectedInternal(); Not accessible as Protected Internal members can not be accessed outside of assembly by creating an object.  
            //mc.GetPrivateProtected(); Not accessible as Private Protected members are not accessible outside of assembly by creating an object or through inheritance.      
            GetPublic();
            //GetPrivate(); Not accessible as private members of a class are not accessible outside class.  
            GetProtected();
            //GetInternal(); Not accessible as internal members are not accessible outside it's assembly.  
            GetProtectedInternal();
            //GetPrivateProtected(); Not accessible as Private Protected members are not accessible outside of assembly by creating an object or through inheritance.    
        }
    }
}

