using System;

namespace _3_Stop_Sign
{
    class Program
    {
        static void Main()
        {

            int n = int.Parse( Console.ReadLine() );

            Console.WriteLine($"{ new string('.', n +1) }{new string('_', n * 2 + 1)}");


            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
