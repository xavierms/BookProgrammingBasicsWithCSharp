using System;
using System.Collections.Generic;
using System.Linq;

namespace _8_Equal_Pairs
{
    class Program
    {
        static void Main()
        {

            Console.Write("Numero: ");

            int n = int.Parse(Console.ReadLine());

            List<int> number1 = new List<int>();


            for (int i = 1; i <= n; i++)
            {

                int numeros_sumatoria  = int.Parse(Console.ReadLine());
                int numeros_sumatoria1 = int.Parse(Console.ReadLine());
                number1.Add(numeros_sumatoria+numeros_sumatoria1);
         
            }
            for (int i = 0; i < number1.Count - 1; i++)
            {
                List<int> diff = new List<int>();
                if ( number1[i] != number1[i++] )
                {
                    for(int ab = 0; ab < number1.Count - 1; ab++)
                    
                    {
                        diff.Add(Math.Abs(number1[ab] - number1[ab + 1]));
                    
                    }
                    Console.WriteLine("No,\n maxima diferencia  = {0}", diff.Max());
                    break;


                }
              
            }
            Console.WriteLine("Si, valor= "+ number1.First());


            //Detener el prog, borrar y retornar al metodo main "inicio"
            Console.ReadKey();
                Console.Clear();
                Main();
        }
    }
}
