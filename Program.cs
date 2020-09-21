using System;
using Demo;

namespace DotNetCoreSample
{
    public delegate int Transform(int x);
    public delegate void ProgressReporter(int percentComplete);
    public delegate T Transformer<T>(T arg);
    class X{
        public void InstanceProgress(int percentComplete)=>Console.WriteLine(percentComplete);
    }
    class Util{
        public static void Transform<T>(T[] values,Func<T,T> t){
            for(int i=0;i<values.Length;i++){
                values[i]=t(values[i]);
            }
        }
    }
    public class Program
    {
        static int Square(int x){
            var result=x*x;
            
            return result;
        }

        static int Cube(int x){
            var result=x*x*x;
            Console.WriteLine(result);
            return result;
        }
        static void Main(string[] args)
        {
            // int[] values={1,2,3};
            // Util.Transform(values,Square);
            // foreach(int i in values)
            //     Console.Write(i+" ");
            
        }
    }
}
