using System;

namespace how_to_become_a_programmer
{
    class Program
    {
        static void Main(string[] args)
        {

            //1 un programa que reproduce la nota musical "A"
            Console.Beep(432, 500);

            //2 un programa que reproduce una secuencia de notas musicales
            for (int i = 200; i <=4000 ; i += 200)
            {
                Console.Beep(i, 100);
            }

            //3 un programa que convierte USD a EUR
            var dollars = int.Parse(Console.ReadLine());
            var euro = dollars * 0.883795087;
            Console.WriteLine(euro);

            

        }
    }
}
