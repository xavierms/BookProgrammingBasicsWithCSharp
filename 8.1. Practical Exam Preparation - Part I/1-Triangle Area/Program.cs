using System;

namespace _1_Triangle_Area
{
    class Program
    {
        static void Main()
        {

            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());

            int a = Math.Abs(x2 - x3);
            int h = Math.Abs(y2 - y1);


            double s = (double)a * h / 2;

            Console.WriteLine($"Área del triángulo: {s}");
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
