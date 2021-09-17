using System;

namespace _14_Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Horas= ");
            double horas = double.Parse(Console.ReadLine());
            Console.Write("Minutos= ");
            double minutes = double.Parse(Console.ReadLine());

            DateTime dateTime = new DateTime()
                .AddMinutes(minutes + 15)
                .AddHours(horas);

            Console.WriteLine(dateTime.ToString("H:mm"));

        }
    }
}
