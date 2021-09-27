using System;

namespace _5_Date_After_5_Days
{
    class Program
    {
        static void Main()
        {
            Console.Write("Dia: ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Mes: ");
            int m = int.Parse(Console.ReadLine());


            int diasEnMes = 31;
            if (m == 2)
            {
                diasEnMes = 28;
            }
            if (m ==4 || m == 6 || m == 9 || m == 11)
            {
                diasEnMes = 30;
            }
            //incrementar 5 dias.
            d += 5;

            //si los dias son mayores ej: 34, entonces se le resta el valor mes : 31, entonces: d=3
            //e incrementamos el mes al siguente, y verificamos si es mayor a 12 entonces sera igual 1 o sea enero.

            if (d > diasEnMes)
            {
                d -= diasEnMes;
                m++;
                if (m > 12)
                {
                    m = 1;
                }
            }
           

            Console.WriteLine("Fecha: {0}/{1:D2}",d,m);


            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
