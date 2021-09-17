using System;

namespace _03_Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dias de vacaciones: ");
            int vacaciones = int.Parse(Console.ReadLine());

            int norma            = 30000;
            int En_diasDeTrabajo = 63;
            int En_vacaciones    = 127;
            int year             = 365;
            int dias_Laborales   = year - vacaciones;

            int Minutos_A_Horas = (dias_Laborales * En_diasDeTrabajo) + (vacaciones * En_vacaciones);
            int Diferencia_Norma_Horas = (norma - Minutos_A_Horas);
            int A_Horas =(Diferencia_Norma_Horas / 60) * -1;
            int A_Minutos = (Diferencia_Norma_Horas % 60 * -1);

            if (Minutos_A_Horas < norma)
            {
                Console.WriteLine("Tom duerme bie");
                Console.WriteLine($" {A_Horas} horas y { A_Minutos }  minutos menos para jugar");

            }
            else
            {
                Console.WriteLine("Tom huirá");
                Console.WriteLine($"{ A_Horas} horas y { A_Minutos } minutos más para jugar");

            }
        }
    }
}
