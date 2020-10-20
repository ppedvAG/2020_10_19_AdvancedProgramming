﻿using System;

namespace SingletonSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Singleton Pattern Demo***\n");            
            //Console.WriteLine(Singleton.MyInt);            
            // Private Constructor.So,we cannot use 'new' keyword.                        
            
            Console.WriteLine("Trying to create instance s1.");            
            Singleton s1 = Singleton.Instance;            
            Console.WriteLine("Trying to create instance s2.");            
            Singleton s2 = Singleton.Instance;            
            
            if (s1 == s2)            
            {                
                Console.WriteLine("Only one instance exists.");            
            }            
            else            
            {                
                Console.WriteLine("Different instances exist.");            
            }            
            Console.Read(); 
        }



    }
}
