using System;

namespace _3_Back_to_the_Past
{
    class Program
    {
        static void Main()
        {
            Console.Write("Herencia: ");
            double dineroHerencia = double.Parse(Console.ReadLine());
            
            Console.Write("Año, hasta el cual tiene que vivir en el pasado: ");
            double anoRegresoPasado = double.Parse(Console.ReadLine());

           
            
            double gasto = 0;
          

            int edad = 18;
            for (int i = 1800; i <= anoRegresoPasado; i++)
            {
               
                
                if (i % 2 == 0 )
                {
                    dineroHerencia -= 12000;   
                }
                else
                {
                    gasto = (edad * 50) + 12000;
                    dineroHerencia -= gasto;
                }
                edad++;

                
            }

            if (dineroHerencia > 0)
            {
                Console.WriteLine($"¡Sí! Vivirá una vida sin preocupaciones y le quedarán { Math.Round( dineroHerencia,2) } dólares");
            }
            else
            {
                Console.WriteLine($"Necesitará  { Math.Abs(Math.Round( dineroHerencia,2) ) } dólares para sobrevivir");
            }

            //Detener el prog, borrar y retornar al metodo main "inicio"
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
