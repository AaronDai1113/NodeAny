using System;

namespace DotNetCoreSample
{
    public delegate int Transform(int x);
    class Util{
        public static void Transform(int[] values,Transform t){
            for(int i=0;i<values.Length;i++){
                values[i]=t(values[i]);
            }
        }
    }
    public class Program
    {
        static int Square(int x){
            var result=x*x;
            Console.WriteLine(result);
            return result;
        }

        static int Cube(int x){
            var result=x*x*x;
            Console.WriteLine(result);
            return result;
        }
        static void Main(string[] args)
        {
            Transform t=null;
            t+=Square;
            t+=Cube;
            var result=t(3);
        }
    }
}
