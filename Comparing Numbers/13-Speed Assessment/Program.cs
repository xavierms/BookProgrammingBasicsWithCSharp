using System;

namespace _12_Speed_Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese velocidad: ");
            decimal velocidad = decimal.Parse(Console.ReadLine());

            if (velocidad <= 10)
            {
                Console.WriteLine("lento");
            }if (velocidad > 10 && velocidad <=50 )
            {
                Console.WriteLine("promedio");
            }if (velocidad > 50 && velocidad <= 150)
            {
                Console.WriteLine("rápido");
            }if (velocidad >= 150 && velocidad <= 1000)
            {
                Console.WriteLine("ultrarrápido");
            }if (velocidad > 1000)
            {
                Console.WriteLine("extremadamente rápido");
            }
        }
    }
}
