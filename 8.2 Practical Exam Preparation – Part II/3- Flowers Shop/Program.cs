using System;

namespace _3__Flowers_Shop
{
    class Program
    {
        static void Main()
        {
            Console.Write("Cantidad de crisantemos comprados: ");
            double cantidadCrisantemosComprados = double.Parse(Console.ReadLine());
            Console.Write("Cantidad de rosas compradas: ");
            double cantidadRosasCompradas       = double.Parse(Console.ReadLine());
            Console.Write("Cantidad de tulipanes comprados: ");
            double cantidadTulipanesComprados   = double.Parse(Console.ReadLine());
            Console.Write("Temporada: ");
            var temporada   = Console.ReadLine().ToLower();
            Console.Write("Es dia feriado? [ Y = sí / N = no ]:  ");
            var holidays    = Console.ReadLine().ToLower();

            //precios en primavera y verano
            double precioCrisantemosPrimavera = 2.00;
            double precioRosasPrimavera       = 4.10;
            double precioTulipanesPrimavera   = 2.50;

            //precios en invierno y otoño
            double precioCrisantemosInvierno = 3.75;
            double precioRosasInvierno       = 4.50;
            double precioTulipanesInvierno   = 4.15;
            
            double precioTotal = 0;

            if (temporada == "primavera" || temporada == "verano")
            {
               
                precioTotal = (cantidadCrisantemosComprados * precioCrisantemosPrimavera) +
                              (cantidadRosasCompradas       * precioRosasPrimavera)       +
                              (cantidadTulipanesComprados   * precioTulipanesPrimavera);


            }
            else if (temporada == "otoño" || temporada == "otono" || temporada == "invierno")
            {
               
                precioTotal = (cantidadCrisantemosComprados * precioCrisantemosInvierno) +
                              (cantidadRosasCompradas       * precioRosasInvierno)       +
                              (cantidadTulipanesComprados   * precioTulipanesInvierno);

            }
            else
            {
                Console.WriteLine("Introduzca una temporada correcta!");
            }
            //en feriados aumenta un 15%
            if (holidays == "y")
            {
                 precioTotal += (precioTotal * 0.15);
            }
            //5% descuento por mas de 7 flores.
            if (cantidadTulipanesComprados > 7 && temporada == "primavera")
            {
                precioTotal -= (precioTotal * 0.05);
            }
            //10% descuento por 10 o mas de 10 flores.
            if (cantidadTulipanesComprados >= 10 || temporada == "invierno")
            {
                precioTotal -= (precioTotal * 0.10);
            }

            //suma de las cantidades de flores para validar si le toca descuento
            double anyTemporadaTotal = cantidadCrisantemosComprados +
                                  cantidadRosasCompradas +
                                  cantidadTulipanesComprados;

            //descuento de 20% si son mas de 20 flores
            if (anyTemporadaTotal > 20)
            {
                precioTotal = precioTotal - (precioTotal * 0.20);

            }
            Console.WriteLine(Math.Round( precioTotal,2) + 2);
            



            //switch (holidays)
            //{
            //    case "primavera":
            //        precio = cantidadCrisantemosComprados * 2.00;
            //        precio = cantidadRosasCompradas       * 4.10;
            //        precio = cantidadTulipanesComprados   * 2.50;
            //    break;
            //    case "verano":
            //        precio = cantidadCrisantemosComprados * 2.00;
            //        precio = cantidadRosasCompradas       * 4.10;
            //        precio = cantidadTulipanesComprados   * 2.50;
            //    break;
            //    default:
            //        break;
            //}

            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
