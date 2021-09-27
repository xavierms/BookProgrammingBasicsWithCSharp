using System;

namespace _2_Changing_Tiles
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ahorros : ");
            double ahorros          = double.Parse(Console.ReadLine());
            Console.WriteLine("Ancho del piso: ");
            double anchoPiso        = double.Parse(Console.ReadLine());
            Console.WriteLine("Longitud del piso: ");
            double longitudPiso     = double.Parse(Console.ReadLine());
            Console.WriteLine("Lado del rectángulo: ");
            double LadoRectángulo   = double.Parse(Console.ReadLine());
            Console.WriteLine("Altura del rectángulo: ");
            double alturaRectángulo = double.Parse(Console.ReadLine());
            Console.WriteLine("Precio de una loseta en lv (levas búlgaras, BGN): ");
            double precioLoseta     = double.Parse(Console.ReadLine());
            Console.WriteLine("Cuota a pagar al trabajador: ");
            double CuotaPagarTrabajador = double.Parse(Console.ReadLine());


            double areaPiso          = anchoPiso * longitudPiso;
            double areaLocetas       = LadoRectángulo * alturaRectángulo / 2;
            double locetasNecesarias = Math.Round( areaPiso / areaLocetas) + 5;
            double total             = locetasNecesarias * precioLoseta + CuotaPagarTrabajador;
            double resto             = Math.Abs( ahorros - total);
            if (ahorros > total)
            {
                
                Console.WriteLine($"Quedan {resto} lv.");
            }
            else
            {
                Console.WriteLine($"Necesitará {resto} lv.");
            }


            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
