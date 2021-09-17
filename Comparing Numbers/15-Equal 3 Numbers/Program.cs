using System;

namespace _15_Equal_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number 1: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input number 2: ");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input number 3: ");
            int number3 = int.Parse(Console.ReadLine());

            if (number1 == number2 || number2 == number3)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
