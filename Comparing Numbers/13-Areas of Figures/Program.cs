using System;
using System.Collections.Generic;

namespace _13_Areas_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geometric Figure:   1)Square  2)Rectangle  3)Circle  4)Triangle");
            switch (double.Parse( Console.ReadLine() ) )
            {
                case 1:
                    Console.WriteLine("--Square--");
                    Console.Write("Size: ");
                    double square = double.Parse(Console.ReadLine());
                    Console.Write("Side: " + square * square);

                    break; 

                   case 2:
                    Console.WriteLine("--Rectangle--");
                    Console.Write("Lenght: ");
                    double rectangle = double.Parse(Console.ReadLine());
                    Console.Write("Size: ");
                    double rectangle1 = double.Parse(Console.ReadLine());
                    Console.Write("Side: " + rectangle * rectangle1);
                    break;

                case 3:
                    Console.WriteLine("--Circle--");
                    Console.Write("Size: ");
                    double Circle = double.Parse(Console.ReadLine());
                    double Area = Math.PI * Circle * Circle;
                    Console.Write("Side: " + Area);

                    break; 
                case 4:
                    Console.WriteLine("--Triangle--");
                    Console.Write("Base: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double h = double.Parse(Console.ReadLine());
                    Console.Write("Side: " +( b * h) / 2);

                    break;
                default:
                    Console.Write("Error");
                    
                    break;
            }
        }
        
    }
}
