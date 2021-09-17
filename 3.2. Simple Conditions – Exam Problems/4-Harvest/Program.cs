using System;

namespace _4_Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("tamaño del viñero: ");
            double the_vineyard_size = double.Parse(Console.ReadLine());

            Console.Write("Cantidad de uvas kg:");
            double grapes_kg = double.Parse(Console.ReadLine());

            Console.Write("Litros de vinos necesarios: ");
            double needed_liters_of_wine = double.Parse(Console.ReadLine());

            Console.Write("Cantidad de trabajadores: ");
            double number_of_workers = double.Parse(Console.ReadLine());

            double cosecha_Litros = the_vineyard_size * grapes_kg * 0.40 ;
            double vino = cosecha_Litros / 2.5;
           
           
           
            if (cosecha_Litros < needed_liters_of_wine)
            {
                double litros_restantes = vino % needed_liters_of_wine;
                Console.WriteLine($"¡Buena cosecha este año! Vino total: {vino} litros.");
                Console.WriteLine("Quedan {0} litros -> {1} litros por persona.", Math.Ceiling(litros_restantes), Math.Ceiling( litros_restantes / number_of_workers  ));

            }
            else
            {
                Console.WriteLine("¡Será un invierno duro! Se necesitan más litros de vino {0}", Math.Floor(needed_liters_of_wine % vino));
            }
        }
    }
}
