using System;

namespace _2_Numbers_Pyramid
{
    class Program
    {
        static void Main()
        {
            Console.Write("#:");
            int n = int.Parse(Console.ReadLine());
            int num = 1;

            for (int fila = 1; fila <= n; fila++)
            {
                for (int col = 1; col <= fila; col++)
                {
                    if (col > 1)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(num);
                    num++;
                    if (num > n)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                if (num > n)
                {
                    break;
                }
            }





            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
