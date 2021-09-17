using System;

namespace Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Insert N length to the Square");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', n));
            for (int i = 1; i <=n-2; i++)
            {
                Console.Write("*");
                Console.Write(new string(' ', n-2));
                Console.WriteLine("*");
            }
            //for (int i = 1; i <= n-2; i++)
            //{
            //    Console.Write("*");
            //    Console.Write(new string('-', n-2));
            //    Console.WriteLine("*");
            //}
            Console.WriteLine(new string('*', n));
        }
    }
}
