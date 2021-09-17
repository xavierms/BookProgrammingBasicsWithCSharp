using System;
using System.Collections.Generic;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitcoins: ");
            double Bitcoins = double.Parse(Console.ReadLine());
            Console.Write("Yuan: ");
            double Yuan     = double.Parse(Console.ReadLine());
            Console.Write("Tarfa: ");
            double Tarifa   = double.Parse(Console.ReadLine());

            double BTC = 1168;
            double CNY = 0.15;
            double USD = 1.76;
            double EUR = 1.95;


            double aBGN1 = Math.Round( Bitcoins * BTC);
            double aUSD = Yuan * CNY;
            double aBGN = aUSD * USD;
            double aEUR = (aBGN1 + aBGN) / EUR;
            double comision = Tarifa * aEUR;
            double total =    aEUR - comision  ;

            Console.WriteLine("Result:  " + total);

            
        }
       
    }
}
