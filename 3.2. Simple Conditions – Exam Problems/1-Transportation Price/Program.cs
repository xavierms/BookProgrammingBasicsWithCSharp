using System;

namespace _1_Transportation_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kilometros recorridos: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba si viaja de Dia o Noche:");
            string dianoche = Console.ReadLine().ToLower();
            double tarifa = 0;

            if (dianoche == "dia")
            {
                tarifa = 0.79;
            }
            if (dianoche == "noche")
            {
                tarifa = 0.90;
            }
            if ( n < 20 )
            {
                Console.Write("Monto a pagar: € " +  (n * tarifa  + 0.70) + " EUR");
            }
            else if(n < 100)
            {
                Console.Write("Monto a pagar: € " + Math.Round( n * 0.09,2)  + " EUR");
            }
            else 
            {
                Console.Write("Monto a pagar: € " + Math.Round(n * 0.06, 2) + " EUR");
            }
        }
    }
}
