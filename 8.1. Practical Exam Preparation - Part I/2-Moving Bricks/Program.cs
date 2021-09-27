using System;

namespace _2_Moving_Bricks
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Cantidad de ladrillos: ");
            int x  = int.Parse(Console.ReadLine());
            Console.WriteLine("Cantidad de trabajadores: ");
            int w  = int.Parse(Console.ReadLine());
            Console.WriteLine("Capacidad del carro: ");
            int my = int.Parse(Console.ReadLine());


            int ladrillos = w * my;

            double total = Math.Ceiling((double)x / ladrillos);

            Console.WriteLine($"Carriles necesarios: {total}");

            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
