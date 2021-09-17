using System;

namespace Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Longitud del suelo:");
            double LongitudSuelo      = double.Parse(Console.ReadLine());//20
            Console.Write("Ancho baldosa: ");
            double AnchoBAldosa       = double.Parse(Console.ReadLine());//5
            Console.Write("Longitud de la baldosa: ");
            double LongitugBaldosa    = double.Parse(Console.ReadLine());//4
            Console.Write("Ancho banco: ");
            double AnchoBanco         = double.Parse(Console.ReadLine());//1
            Console.Write("Longitud del banco:");
            double LongitudBanco      = double.Parse(Console.ReadLine());//2

            double areaBAldosa = LongitugBaldosa * AnchoBAldosa;
            double areaT       = LongitudSuelo * areaBAldosa;
            double areabanco   = AnchoBanco * LongitudBanco;
            double espacio     =  areaT - areabanco;
            double FichasNEcesarias = espacio / LongitudSuelo;
            double TiempoCambio = FichasNEcesarias * 0.2;
            Console.WriteLine("Mosaicos para la reparacion: " + Math.Round( FichasNEcesarias,3));
            Console.WriteLine("Tiempo de cambio: " + Math.Round(TiempoCambio, 3) );
            if (TiempoCambio >= 1)
            {
                Console.Write("Minutos");
            }
            else
            {
                Console.Write("Segundos");
            }
        }
    }
}
