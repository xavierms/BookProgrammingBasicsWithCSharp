using System;

namespace Date_Calculations___1000_Days_on_the_Earth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inser Birth Day: ");
            var dateTime  =DateTime.Parse( Console.ReadLine() ).AddDays(1000).ToString("dd-MM-yyyy");
            Console.WriteLine(dateTime);

            Console.WriteLine("Hello World!");
        }
    }
}
