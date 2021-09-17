using System;

namespace Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert lenght: ");
            double lenght = double.Parse(Console.ReadLine());

            Console.Write("Insert width: ");
            double width = double.Parse(Console.ReadLine());



            double columnas = Math.Round( (width - 100) / 70);
            double filas    = Math.Round( lenght / 120);
            double puestos = filas * columnas - 3;

            Console.WriteLine("puestos: " + Math.Round( puestos,2));
             
        }
    }
}
