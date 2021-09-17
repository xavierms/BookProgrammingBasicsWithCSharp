using System;

namespace Game_Tickets
{
    class Program
    {
        static void Main()
        {


            Console.WriteLine("**Game Tickets**\n");
            Console.WriteLine("----------------");

            
            
            //inputs
            double presupuesto_transporte = double.Parse(Console.ReadLine());
            var categoria_precios         = Console.ReadLine().ToLower();
            double cantidaPersonas        = double.Parse( Console.ReadLine() );

            //porcentajes dependiendo el rango de personas
           
            double porcentaje    = 0;
            double precioEntrada = 0;
            
            
            //categorias de precios
            switch (categoria_precios)
            {
                case "vip":
                    precioEntrada = cantidaPersonas * 499.99;
                    break;
                case "normal":
                    precioEntrada = cantidaPersonas * 249.99;
                    break;
                default:
                    precioEntrada = cantidaPersonas * 249.99;
                    break;
            }
            if (cantidaPersonas <= 4)
            {
                //75%
                porcentaje = presupuesto_transporte * 0.75;
            }
            else if (cantidaPersonas >= 5 && cantidaPersonas <= 9)
            {
                porcentaje = presupuesto_transporte * 0.60;
            }
            else if (cantidaPersonas >=10 && cantidaPersonas <= 9)
            {
                porcentaje = presupuesto_transporte * 0.50;
            }
            else if (cantidaPersonas >= 25 && cantidaPersonas <= 49)
            {
                porcentaje = presupuesto_transporte * 0.40;
            }
            else //if(cantidaPersonas >=50)
            {
                porcentaje = presupuesto_transporte * 0.25;
            }
            
            double cantidaRestante = presupuesto_transporte - porcentaje;
            if (precioEntrada < cantidaRestante)
            {

                Console.WriteLine($"¡Sí! Te queda {Math.Round( cantidaRestante - precioEntrada,2)} leva ");

            }
            else if (precioEntrada > cantidaRestante)
            {
                Console.WriteLine($"¡Dinero insuficiente! Necesita {Math.Round(precioEntrada - cantidaRestante  , 2)} leva.");
            }






            //detener el prog, borrar y retornar al metodo main "inicio"
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
