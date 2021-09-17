using System;

namespace _2_Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Año: ");
            string anio = Console.ReadLine().ToLower();

            Console.WriteLine("Dias festivos para jugar: ");
            double dias_festivos = double.Parse(Console.ReadLine());

            Console.WriteLine("Veces que viaja al año: ");
            double fines_Semana_en_Sofia = double.Parse(Console.ReadLine());


            double finesSemana_sofia = 48 - fines_Semana_en_Sofia;
            double juegoen_sofia = (3 * finesSemana_sofia /4) +( 2 * dias_festivos / 3)  ;
            double total = fines_Semana_en_Sofia + juegoen_sofia;
            
            

            if (anio == "bisiesto")
            {
                Console.WriteLine("En año bisiesto:  {0}", Math.Truncate( total + total * 0.15 ));
            }
            else if (anio == "normal")
            {
                Console.WriteLine("En año normal:  {0}", Math.Truncate( total  ));
            }


            
        }

        
    }
    
}
