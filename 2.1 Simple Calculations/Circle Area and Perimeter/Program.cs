using System;

namespace Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Radius: ");
            double r = double.Parse(Console.ReadLine());

            double Area = Math.PI * r * r;
            double perimeter = 2 * Math.PI * r;

            
            Console.WriteLine("Area {0} and perimeter {1}.",Area, perimeter);
        }
    }
}
