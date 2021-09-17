using System;

namespace Numbers_from_100_to_200
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insertar numero: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
            {
                if (numero < 100)
                {
                    Console.WriteLine("Menos de 100");
                }
                else if (numero > 100 && numero < 200)
                {
                    Console.WriteLine("Entre 100 y 200");
                }
                else if (numero > 200)
                {
                    Console.WriteLine("Mayor que 200");
                }
            }
            else
            {
                Console.WriteLine("No es un numero entero");
            }
        }
    }
}
