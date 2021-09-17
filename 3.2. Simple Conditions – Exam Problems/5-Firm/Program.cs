using System;

namespace _5_Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Horas necesarias: ");
            double hora_necesarias         = double.Parse(Console.ReadLine());

            Console.Write("Dias que tiene la empresa para el pryecto: ");
            double dias = double.Parse(Console.ReadLine());

            Console.Write("Numero de lo trabajadores: ");
            double numero_trabajadores     = double.Parse(Console.ReadLine());


            double jornada_laboral = dias * 0.90; 

            double horas_extras = numero_trabajadores * 2 * jornada_laboral ; 

            double horas_trabajo = (8 * numero_trabajadores)*jornada_laboral + horas_extras;


            if (horas_trabajo >  hora_necesarias)
            {
                Console.WriteLine("¡Sí! Quedan {0} horas.", horas_trabajo - hora_necesarias);
            }
            else
            {
                Console.WriteLine("¡No hay suficiente tiempo! Se necesitan {0} horas.",Math.Abs( horas_trabajo - hora_necesarias ));
            }
        }
    }
}
