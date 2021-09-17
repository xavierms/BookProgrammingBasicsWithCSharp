using System;

namespace Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //Formula area de un triangulo   a * h / 2.
            Console.Write("Side:  ");
            double side = double.Parse(Console.ReadLine());

            Console.Write("Height:  ");
            double height = double.Parse(Console.ReadLine());

            double area = side * height / 2;


            Console.WriteLine("Triangle Area = " + Math.Round(area, 2));
        }
    }
}
