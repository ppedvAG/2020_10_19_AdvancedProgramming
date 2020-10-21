using System;
using System.Reflection;

namespace HelloReflections
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly geladen = Assembly.LoadFrom("netcoreapp3.1\\TrumpTaschenrechner.dll");

            var allTypes = geladen.GetTypes(); // Den Typ ermitteln

            Type TaschnrechnerTyp = geladen.GetType("TrumpTaschenrechner.Taschnrechner");

            object tr = Activator.CreateInstance(TaschnrechnerTyp);

            MethodInfo addInfo = TaschnrechnerTyp.GetMethod("Add", new Type[] { typeof(Int32), typeof(Int32) });

            var result = addInfo.Invoke(tr, new object[] { 6, 4 });
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
