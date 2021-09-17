using System;

namespace Excellent_Grade_or_Not
{
    class Program
    {
        static void Main(string[] args)
        {
            int grado = int.Parse(Console.ReadLine());

            if (grado >= 5.4)
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                Console.WriteLine("Not excellent.");
            }
        }
    }
}
