using System;

namespace _01_Excellent_Grade
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
                Console.WriteLine("Bad");
            }
        }
    }
}
