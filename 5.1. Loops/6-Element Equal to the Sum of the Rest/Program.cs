using System;
using System.Linq;

namespace _6_Element_Equal_to_the_Sum_of_the_Rest
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("**Element Equal to the Sum of the Rest** \n");


            Console.Write("Numero: ");
            int numero_loop = int.Parse(Console.ReadLine());
            int suma = 0;
            var max = int.MinValue;
            
            for (int i = 1; i <= numero_loop; i++)
            {
                int numero = int.Parse(Console.ReadLine());
                suma += numero; 
                //obtener el numero mayor
                if (numero > max)
                {
                    max = numero;
                }         
            }
            //restarle el numero mayor
            suma -= max;
            if (suma == max)
            {
                Console.WriteLine("si, suma = " + max);
            }
            else
            {
                var diferencia = Math.Abs(suma - max);
                Console.WriteLine("No,\n diferencia es = {0}", diferencia);
            }


            //Detener el prog, borrar y retornar al metodo main "inicio"
            Console.ReadKey();
            Console.Clear();
            Main();
        }
       
    }
}
