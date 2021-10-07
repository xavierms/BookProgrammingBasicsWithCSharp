using System;

namespace _1_Passion_Shopping_Days
{
    class Program
    {
        static void Main()
        {

            double presupuesto  = double.Parse(Console.ReadLine());
            var mallEnterCMD    = Console.ReadLine();          
            int compras         = 0;

            if (mallEnterCMD == "mall.Enter")
            {
                while (mallEnterCMD != "mall.Exit")
                {
                    var acciones =  Console.ReadLine();
                    if (acciones == "mall.Exit")
                    {
                        break;
                    }
                    for (int i = 0; i < acciones.Length ; i++)
                    {

                                 //var character = char.Parse(acciones[i]);

                            //if (acciones[i] > presupuesto)
                            //{
                            //    Console.WriteLine("Los fondos de Lina no pueden ser inferiores a 0!");

                            //break;
                            //}
                            if ( acciones[i] >= 'A' && acciones[i] <= 'Z')
                            {
                                 presupuesto -=  (acciones[i] * 0.50);
                            }
                            else if (acciones[i] >= 'a' && acciones[i] <= 'z')
                            {
                            presupuesto -=   (acciones[i] * 0.30);
                            }
                            else if (acciones[i] == '%')
                            {
                            presupuesto /=  2;
                            }
                            else if (acciones[i] == '*')
                            {
                            presupuesto +=   10;
                            }
                            else
                            {
                            presupuesto -=   acciones[i];
                            }
                    
                     
                    }
                            compras++;
                    
                }
            }

            if (compras >= 1)
            {
                Console.WriteLine($"{compras} compras. Sobrante: { presupuesto.ToString("0.00") } lv.");
            }
            

            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
