using System;

namespace _2_Pipes_in_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Volumen de la piscina en litros: ");
            double V = double.Parse(Console.ReadLine());

            Console.Write("El caudal de la primera tuberia por hora: ");
            double P1 = double.Parse(Console.ReadLine());

            Console.Write("El caudal de la segunda tuberia por hora: ");
            double P2 = double.Parse(Console.ReadLine());

            Console.Write("Las horas que el trabajador está ausente: ");
            double H = double.Parse(Console.ReadLine());

            double agua = (P1 + P2 )* H * 0.100 ;
          

            if (agua < V)
            {
                Console.WriteLine("La piscina está {0} % llena. Tubería 1: {1} %. Tubería 2: {2} % ", agua , Math.Truncate((P1 * H / agua) /0.100), Math.Truncate((P2 * H / agua) / 0.100));

            }
            else
            {
                Console.WriteLine("Durante {0} horas la piscina se desborda con {1} litros", H, agua - V);
            }

            
        }
    }
}
