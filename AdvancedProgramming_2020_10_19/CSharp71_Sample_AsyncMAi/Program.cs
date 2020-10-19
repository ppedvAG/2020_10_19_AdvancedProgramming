using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp71_Sample_AsyncMain
{
    class Program
    {

        //async gibt im Methoden an, dass innheralb in der Methode ein asynchoner call verwendet wird
        async void Main(string[] args)
        {
            await Task.Delay(200); //Task.Delay ist ein quasi 
        }
    }
}
