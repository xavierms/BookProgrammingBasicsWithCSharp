using System;

namespace _2_Trip
{
    class Program
    {
        static void Main()
        {
            Console.Write("Presuesto a gastar:  ");
            double budget = double.Parse(Console.ReadLine().ToLower());
            Console.Write("Escribir que temporada del año: \n 1-summer o 2-winter  ");
            var season_year    = Console.ReadLine();

            Console.WriteLine("--------------");
            double to_spend = 0;
            
            if (budget <= 100)
            {
                //Bulgaria
                if (season_year == "summer")
                {
                    to_spend = budget * 0.30;
                    Console.WriteLine("Somewhere in de Bulgaria \n Camp - {0} ", String.Format("{0:#.00}", to_spend ));
                }
                else
                {
                    to_spend = budget * 0.70;
                    Console.WriteLine("Somewhere in de Bulgaria \n Hotel - {0}", String.Format("{0:#.00}", to_spend ));
                }
            }
            if (budget > 100 && budget <= 1000)
            {
                //Balkans
                if (season_year == "summer")
                {
                    to_spend = budget * 0.40;
                    Console.WriteLine("Somewhere in Balkans \n Camp - {0} ", String.Format("{0:#.00}", to_spend));
                }
                else
                {
                    to_spend = budget * 0.80;
                    Console.WriteLine("Somewhere in de Balkans \n Hotel - {0}", String.Format("{0:#.00}", to_spend ));
                }
            }
            if (budget > 1000)
            {
                //Europe
                if (season_year == "summer")
                {
                    to_spend = budget * 0.90;
                    Console.WriteLine("Somewhere in Europe  \n Camp - {0}", String.Format("{0:#.00}", to_spend));
                }
                else
                {
                    to_spend = budget * 0.90;
                    Console.WriteLine("Somewhere in Europe \n Hotel - {0}", String.Format("{0:#.00}", to_spend ));
                }
            }
            Console.ReadKey();
            Console.Clear();
            Main();
        }
        
    }

}
