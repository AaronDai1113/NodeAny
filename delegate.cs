using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate{
    public delegate void GreetingDelegate(string name);
    class Program{
        public static void EnglishGreeting(string name){
            Console.WriteLine("Morning, "+name);
        }
        public static void ChineseGreeting(string name){
            Console.WriteLine("早上好，"+name);
        }

        // public static void GreetPeople(string name,GreetingDelegate MakeGreeting){
        //     MakeGreeting(name);
        // }
    }
}