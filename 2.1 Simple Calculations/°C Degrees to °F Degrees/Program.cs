using System;

namespace _C_Degrees_to__F_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            //F = (C · 1,8) + 32
            Console.Write("Celsius °C :");
            double C = double.Parse(Console.ReadLine());

            double F = (C * 1.8) + 32;

            Console.WriteLine("Fahrenheit °F: {0}",Math.Round(F,2));
        }
    }
}
