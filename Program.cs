using System;

namespace DotNetCoreSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Food food1=FoodSimpleFactory.CreateFood("A");
            food1.Print();

            Food food2=FoodSimpleFactory.CreateFood("B");
            food2.Print();
            Console.Read();
        }
    }
}
