using System;

namespace _3_Point_in_the_Figure
{
    class Program
    {
        static void Main()
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());



            if (  ( x < h && y > h ) || (x > h *2 && y > h) || y > 4* h || x > h * 3 || x < 0 || y < 0  )
            {
                Console.WriteLine("fuera");
            }
            else if ( (x > 0 && y > 0) || (y < h && y < 0 ) )
            {
                Console.WriteLine("dentro");
            }
            else
            {
                Console.WriteLine("borde");
            }

            Console.ReadKey();
            Console.Clear();
            Main();


        }
    }
}
