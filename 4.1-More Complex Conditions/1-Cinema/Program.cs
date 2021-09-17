using System;

namespace _1_Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.Write("Tipo: ");
            string tipo= Console.ReadLine().ToLower();
            Console.Write("Filas: ");
            double filas= double.Parse(Console.ReadLine());
            Console.Write("Columnas: ");
            double columnas = double.Parse(Console.ReadLine());

            double capacidad = filas * columnas;
            double ingresos_totales ;


            if (tipo == "estreno")
            {
                ingresos_totales = capacidad * 12.00; 
                Console.WriteLine("Tipo proyección: Estreno "   + string.Format("{0:0.00}", ingresos_totales) + " EUR" );
            }if (tipo == "normal")
            {
                ingresos_totales = capacidad * 17.50;
                Console.WriteLine("Tipo proyección: normal "    + string.Format("{0:0.00}", ingresos_totales) + " EUR" );
            }if(tipo == "descuento")
            {
                ingresos_totales = capacidad * 5.00;
                Console.WriteLine("Tipo proyección: descuento " + string.Format("{0:0.00}", ingresos_totales) + " EUR" );
            }
        }
    }
}
