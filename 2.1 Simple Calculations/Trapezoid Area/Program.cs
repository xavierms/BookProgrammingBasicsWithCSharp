using System;

namespace Trapezoid_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            // Formula area de un trapezoide (b1 + b2) * h / 2
            Console.Write("Base 1: ");
            double b1 = double.Parse(Console.ReadLine());

            Console.Write("Base 2: ");
            double b2 = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            double h  = double.Parse(Console.ReadLine());

            double area = (b1 + b2) * h / 2; 
            Console.WriteLine("Trapezoid Area = " + area);
        }
    }
}
