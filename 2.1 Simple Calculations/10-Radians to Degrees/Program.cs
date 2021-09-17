using System;

namespace _10_Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Angle: ");
            double angle = double.Parse(Console.ReadLine());

            double degress =angle * (180 / Math.PI);
            Console.WriteLine("Degress: " + Math.Round(degress,2));
        }
    }
}
