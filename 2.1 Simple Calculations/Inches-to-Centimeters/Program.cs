﻿using System;

namespace Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double inch = double.Parse(Console.ReadLine());
            Console.WriteLine("Inches :" + inch );

            double centimeter = inch * 2.54;

            Console.WriteLine("Centimeter: "+ centimeter);
        }
    }
}
