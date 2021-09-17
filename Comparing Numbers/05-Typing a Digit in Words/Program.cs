using System;

namespace _05_Typing_a_Digit_in_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 10)
            {
                Console.WriteLine("The number is too big!");
            }
            else
            {
                Console.WriteLine("In range [0 - 9] :" + numero);
            }

        }
    }
}
