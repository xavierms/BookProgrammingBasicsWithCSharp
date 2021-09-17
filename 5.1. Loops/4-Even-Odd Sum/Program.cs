using System;

namespace _4_Even_Odd_Sum
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("**Even / Odd Sum** \n");
            
            Console.Write("Numero: ");
            int numero_loop = int.Parse(Console.ReadLine());

            int par = 0;
            int impar = 0;
            for (int loop = 1; loop <= numero_loop; loop++)
            {
               int numeros_sumatoria = int.Parse(Console.ReadLine());

                if ( loop %  2 ==0)
                {
                 
                    impar += numeros_sumatoria;
                }
                else
                {
                    par += numeros_sumatoria;
                }

            }
           
            //si son iguales 
            if (par == impar)
            {
                Console.WriteLine("Sí,\n suma = {0}", par);
            }
            else
            {
                var diferencia = Math.Abs(impar - par);
                Console.WriteLine("No,\n diferencia es = {0}", diferencia);
            }


            //Detener el prog, borrar y retornar al metodo main "inicio"
            Console.ReadKey();
            Console.Clear();
            Main();

        }
    }
}
