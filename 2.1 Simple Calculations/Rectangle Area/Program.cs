using System;

namespace Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert x1: ");
            double x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insert y1: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insert x2: ");
            double x2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insert y2: ");
            double y2 = double.Parse(Console.ReadLine());

            //Igual al largo por el ancho
            double area = x1 * y1; 
            //Igual a la suma de sus cuatro lados
            double perimeter = 2* (x2 + y2);

            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);

       
        }
    }
}
