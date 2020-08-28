using System;

namespace DotNetCoreSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Delegate.GreetingDelegate Eng,Chi;
            Eng=Delegate.Program.EnglishGreeting;
            Chi=Delegate.Program.ChineseGreeting;
            Delegate.Program.GreetPeople("hello",Eng);
            
            
        }
    }
}
