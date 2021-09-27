using System;

namespace _4_Point_in_a_Figure
{
    class Program
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());


            bool pointInRect1 = x >= 2
                             && x <= 12
                             && y >= -3
                             && y <= 1;
            bool pointInRect2 = x >= 4
                             && x <= 10
                             && y >= -5
                             && y <= 3;

            if (pointInRect1 || pointInRect2)
            {
                Console.WriteLine("Dentro");
            }
            else
            {
                Console.WriteLine("Fuera");
            }

            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
