using System;
using System.Collections.Generic;

namespace _2_Smart_Lilly
{
    class Program
    {
        static void Main()
        {
            Console.Write("Edad:");
            int edad           = int.Parse(Console.ReadLine());
            double precioLavadora = double.Parse(Console.ReadLine());
            double PrecioJuguete  = double.Parse(Console.ReadLine());

            double cantidadJuguete = 0;
            double ventaJuguete    = 0;
            double DineroGanado    = 10;
            double ahorro = 0;

            for (int i = 1; i <= edad; i++)
            {
                  //edad--;
                if (i % 2 == 0)
                {
                    //recibe un juguete
                    ahorro += DineroGanado -1;
                    DineroGanado += 10 ; 

                    
                }
                else
                {

                    cantidadJuguete++;
                    ventaJuguete = PrecioJuguete * cantidadJuguete;
                }
            }
            ahorro += ventaJuguete;
            double diff = ahorro - precioLavadora;
            if (ahorro >= precioLavadora)
            {
                Console.WriteLine($"Si,{Math.Abs(  diff )} ");
            }
            else
            {
                Console.WriteLine($"No!, {Math.Abs( diff )}");
            }
            

            //Detener el prog, borrar y retornar al metodo main "inicio"
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
