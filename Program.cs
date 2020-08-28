using System;

namespace DotNetCoreSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Food food=Customer.Cook("A"); 
            Food food1=Customer.Cook("B");            
            
            food.Print();
            food1.Print();
        }
    }
}
