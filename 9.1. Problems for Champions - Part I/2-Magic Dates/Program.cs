using System;

namespace _2_Magic_Dates
{
    class Program
    {
        static void Main()
        {

            int anoInicio = int.Parse(Console.ReadLine());
            //int mes = int.Parse(Console.ReadLine());
            //int dia = int.Parse(Console.ReadLine());
            int anoFinal = int.Parse(Console.ReadLine());
            int weight = int.Parse(Console.ReadLine());

            int dataWeight = 0;
            DateTime currentDate = new DateTime(anoInicio, 1, 1);
            var found = false;
            for (int i = currentDate.Year; currentDate.Year <= anoFinal; i++)
            {
                int d1 = currentDate.Day / 10;
                int d2 = currentDate.Day % 10;

                int d3 = currentDate.Month / 10;
                int d4 = currentDate.Month % 10;

                int d5 = currentDate.Year / 1000;
                int d6 = (currentDate.Year / 100) % 10;
                int d7 = (currentDate.Year / 10) % 10;
                int d8 = currentDate.Year % 10;

                //27 for
                //for (int d1 = 0; d1 < length; d1++)
                //{

                //}
                dataWeight = d1 * (d2 + d3 + d4 + d5 + d6 + d7 + d8) +
                             d2 * (d3 + d4 + d5 + d6 + d7 + d8) +
                             d3 * (d4 + d5 + d6 + d7 + d8) +
                             d4 * (d5 + d6 + d7 + d8) +
                             d5 * (d6 + d7 + d8) +
                             d6 * (d7 + d8) +
                             d7 * (d8);
                currentDate = currentDate.AddDays(1);
            if (dataWeight == weight)
            {
                    found = true;
                    Console.WriteLine(currentDate.AddDays(-1).ToString("dd-MM-yyyy"));
            }
            }

            if (!found)
            {
                Console.WriteLine("No");
            }


            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
