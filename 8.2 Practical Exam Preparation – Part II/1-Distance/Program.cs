using System;

namespace _1_Distance
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Velocidad inicial en km / h: ");
            double velocidadInicial     = double.Parse(Console.ReadLine());
            Console.WriteLine("Primer período de tiempo en minutos: ");
            double primerPeríodoTiempo  = double.Parse(Console.ReadLine());
            Console.WriteLine("segundo marco de tiempo en minutos: ");
            double segundoPeríodoTiempo = double.Parse(Console.ReadLine());
            Console.WriteLine("tercer período de tiempo en minutos: ");
            double tercerPeríodoTiempo  = double.Parse(Console.ReadLine());

            //distancia en horas

            double distanciaVelocidadinicial = velocidadInicial * (primerPeríodoTiempo / 60);
            double kmH                       = (( velocidadInicial * 0.10) + velocidadInicial) ;
            double aumentoVelocidad          = kmH * (segundoPeríodoTiempo / 60) ;
            double disminucionVelocidad      = (kmH - (kmH *0.05)) *(tercerPeríodoTiempo / 60);
            double numeroTotalKm             = distanciaVelocidadinicial + aumentoVelocidad + disminucionVelocidad;

            Console.WriteLine($"Número total de km recorridos: {Math.Round( numeroTotalKm, 2 )}" + "km");
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
