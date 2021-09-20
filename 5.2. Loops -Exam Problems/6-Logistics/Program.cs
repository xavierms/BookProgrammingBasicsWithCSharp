using System;

namespace _6_Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int recuentoCarga = int.Parse(Console.ReadLine());


            double minibus        = 0;
            double camion         = 0;
            double tren           = 0;
            double sumaToneladas  = 0;
            double porcentMinibus ;
            double porcentCamion  ;
            double porcentTren    ;
            double precioPromedioPorToneladas    = 0;

            for (int i = 0; i < recuentoCarga ; i++)
            {
                int toneladas = int.Parse(Console.ReadLine());

                if (toneladas <= 3 )
                {
                    //minibus
                    minibus +=toneladas;
                }
                else if (toneladas > 3 && toneladas <= 11)
                {
                    camion += toneladas;
                }
                else if(toneladas > 11)
                {
                    tren +=  toneladas;
                }
                

                sumaToneladas += toneladas;
            }
            porcentMinibus =  minibus / sumaToneladas * 100.0;
            porcentCamion  =  camion  / sumaToneladas * 100.0;
            porcentTren    =  tren    / sumaToneladas * 100.0;
            precioPromedioPorToneladas = Math.Round( (minibus * 200 + camion * 175 + tren * 120) / sumaToneladas,2 ) ;


            Console.WriteLine( string.Format("{0:0.00}", precioPromedioPorToneladas) + " %");
            Console.WriteLine( string.Format("{0:0.00}", porcentMinibus)             + " %");
            Console.WriteLine( string.Format("{0:0.00}", porcentCamion)              + " %");
            Console.WriteLine( string.Format("{0:0.00}", porcentTren)                + " %");
        }
    }
}
