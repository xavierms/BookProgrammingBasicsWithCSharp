using System;

namespace Calculating_Square_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a=Int32.Parse(Console.ReadLine());
            //int result = a * a;
            //Console.WriteLine("Area: {0}",a);
            //Console.WriteLine("Square Area: {0}", result);

            Console.Write("a = ");
            var a = int.Parse(Console.ReadLine());
            var area = a * a;
            Console.WriteLine("Square = " + area);
            
        }
    }
}
