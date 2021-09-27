using System;

namespace _9_Perfect_Diamond
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', n - 1 - i));
                Console.Write("*");
                for (int j = 0; j < i ; j++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }
            for (int i = n - 2; i >= 0; i--)
            {
                Console.Write(new string(' ', n - 1 - i));
                Console.Write("*");
                for (int j = 0; j < i ; j++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
