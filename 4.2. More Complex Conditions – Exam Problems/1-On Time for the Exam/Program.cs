using System;

namespace _1_On_Time_for_the_Exam
{
    class Program
    {
        static void Main()
        {




            Console.Write("Hora de inicio del examen (horas): ");
            int inicio_horas = int.Parse(Console.ReadLine());

            Console.Write("Hora de inicio del examen (minutos): ");
            int inicio_minutos = int.Parse(Console.ReadLine());

            Console.Write("Hora de llegada(minutos): ");
            int llegada_horas = int.Parse(Console.ReadLine());

            Console.Write("Hora de llegada(minutos): ");
            int llegada_minutos = int.Parse(Console.ReadLine());

            //int inicio = (inicio_horas * 60) + inicio_minutos;
            //int llegada = (llegada_horas * 60) + llegada_minutos;

            TimeSpan inicio  = new TimeSpan(inicio_horas, inicio_minutos, 00);
            TimeSpan llegada = new TimeSpan(llegada_horas, llegada_minutos, 00);

            var diferencia_tiempo = inicio - llegada ;

          

            if (diferencia_tiempo > new TimeSpan(0,30,0) )
            {
                Console.WriteLine("Temprano");

                if (diferencia_tiempo >= new TimeSpan(1,00,0) )
                {
                    
                    Console.WriteLine("{0} horas antes del inicio",   diferencia_tiempo.ToString("h\\:mm"));
                }
                else if (diferencia_tiempo < new TimeSpan(1,00,0))
                {
                    Console.WriteLine("{0} minutos antes del inicio", Math.Abs(diferencia_tiempo.Minutes));
                }     
               
            }

           else if (diferencia_tiempo <= new TimeSpan(0,30,0) && diferencia_tiempo >= new TimeSpan(0, 00, 0))
            {
                Console.WriteLine("A tiempo");
                if (diferencia_tiempo != new TimeSpan(0, 00, 0))
                {
                    Console.WriteLine("{0} minutos antes del inicio",Math.Abs( diferencia_tiempo.Minutes));
                }
                //else if (diferencia_tiempo < new TimeSpan(0,00,0))
                //{
                //    Console.WriteLine("{0} horas antes del inicio" ,diferencia_tiempo);
                //}
               
               
            }
            else 
            {
                Console.WriteLine("Tarde");
                if (diferencia_tiempo < new TimeSpan(-1, 00, 0))
                {
                    Console.WriteLine("{0} horas despues del inicio", diferencia_tiempo.ToString("h\\:mm"));
                }
                else if (diferencia_tiempo > new TimeSpan(-1, 00, 0))
                {
                    Console.WriteLine("{0} minutos despues del inicio", Math.Abs(diferencia_tiempo.Minutes));
                }
            }

            //string.Format("{0:0:00}"
            Console.ReadKey();
            Console.Clear();
            Main();
        }

    }
}
