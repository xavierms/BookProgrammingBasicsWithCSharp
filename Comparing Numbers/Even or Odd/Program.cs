using System;

namespace Even_or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("par");
            }
            else
            {
                Console.WriteLine("Impar");
            }
        }
    }
}
