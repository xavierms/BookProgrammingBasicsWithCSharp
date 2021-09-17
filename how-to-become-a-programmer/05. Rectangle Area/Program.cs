using System;

namespace _05._Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int l,w,result;

            Console.WriteLine("Insert a base: ");
            l = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Insert a base: ");
            w = Int32.Parse(Console.ReadLine());
            result = l * w;
            Console.WriteLine("result: " + result);
        }
    }
}
