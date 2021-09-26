using System;

namespace _3_Table
{
    class Program
    {
        static void Main()
        {
            Console.Write("#:");
            int n = int.Parse(Console.ReadLine());


            for (int fila = 0; fila < n; fila++)
            {
                for (int col = 0; col < n; col++)
                {
                    int num = fila + col + 1;
                    if (num > n)
                    {
                        num = 2 * n - num;
                    }
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }



            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
