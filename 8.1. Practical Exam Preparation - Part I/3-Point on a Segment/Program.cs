using System;

namespace _3_Point_on_a_Segment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Un extremo del segmento: ");
            int primero = int.Parse(Console.ReadLine());
            Console.WriteLine("El otro un extremo del segmento");
            int segundo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ubicación del punto: ");
            int punto   = int.Parse(Console.ReadLine());

            int izq = Math.Min(primero, segundo);
            int der = Math.Max(primero, segundo);

            int distanciaIzq = Math.Abs(izq - punto);
            int distanciaDer = Math.Abs(der - punto);

            int minDistancia = Math.Min(distanciaIzq, distanciaDer);

            if (punto >= izq && punto <= der)
            {
                Console.WriteLine("Dentro");
            }
            else
            {
                Console.WriteLine("Fuera");
            }

            Console.WriteLine($"Distancia: {minDistancia}");
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
