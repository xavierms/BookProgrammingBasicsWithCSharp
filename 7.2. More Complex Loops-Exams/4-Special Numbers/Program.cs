using System;

namespace _4_Special_Numbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse( Console.ReadLine() );

            int uno    = 0;
            int dos    = 0;
            int tres   = 0;
            int cuatro = 0;


            for (int i = 1111; i < 9999; i++)
            {  
                //obtiene el numero de la milesima
                uno = i / 1000 % 10;
                //obtiene el numero de la decima
                dos = i / 100 % 10;
                //obtiene el numero de la decena
                tres = i / 10 % 10;
                //obtiene el numero de la unidad
                cuatro = i / 1 % 10;

                //si cualquiera de los numero es igua a 0 continuar
            if (uno == 0 || dos == 0 || tres == 0 || cuatro == 0) continue;
                
                if (n % uno == 0 && n % dos == 0 && n % tres == 0 && n % cuatro == 0 )
                {
                    Console.Write(i + ", ");
                }
            }
            
            


            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
