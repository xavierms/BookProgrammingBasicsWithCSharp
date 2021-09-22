using System;

namespace _1_Fibonacci
{
    class Program
    {
        static void Main()
        {
            Console.Write("#:");
            int n = int.Parse(Console.ReadLine());

            int f0 = 1;
            int f1 = 1;
            for (int i = 0; i < n - 1; i++)
            {
                int fnext = f0 + f1;
                f0 = f1;
                f1 = fnext;
            }
            Console.WriteLine(f1);


            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
