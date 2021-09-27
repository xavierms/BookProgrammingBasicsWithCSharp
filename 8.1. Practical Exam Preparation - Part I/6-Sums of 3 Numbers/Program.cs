using System;

namespace _6_Sums_of_3_Numbers
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a + b == c)
            {
                Console.WriteLine($"{a} + {b} = {c}");
            }
            else if (a + c == b)
            {
                Console.WriteLine($"{a} + {c} = {b}");

            }
            else if (b + c == a)
            {
                Console.WriteLine($"{b} + {c} = {a}");

            }
            else
            {
                Console.WriteLine("No");
            }


            Console.ReadKey();
            Console.Clear();
            Main();

        }
    }
}
