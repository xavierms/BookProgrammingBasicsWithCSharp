using System;

namespace Summing_Up_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tiempo 1= ");
            double second1 = double.Parse(Console.ReadLine());
            Console.Write("Tiempo 2= ");
            double second2 = double.Parse(Console.ReadLine());
            Console.Write("Tiempo 3= ");
            double second3 = double.Parse(Console.ReadLine());

            double total = second1 + second2 + second3;
            double minutes = 0;

            if (total > 59)
            {
                minutes++;
                total -= 60;
            }
            if (total > 59)
            {
                minutes++;
                total -= 60;
            }
            if (total < 10)
            {
                Console.WriteLine(minutes + ":" + "0" + total);
            }
            else
            {
                Console.WriteLine(minutes + ":" + total);
            }
        }
    }
}
