using System;

namespace Finding_the_Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número 1: ");
            int g_numero_1 = int.Parse(Console.ReadLine());

            Console.Write("Número 2: ");
            int p_numero_2 = int.Parse(Console.ReadLine());

            if (g_numero_1 > p_numero_2)
            {
                Console.WriteLine("Número mas grande: " + g_numero_1);
            }
            else
            {
                Console.WriteLine("Número mas pequeño: " + p_numero_2);
            }
        }
    }
}
