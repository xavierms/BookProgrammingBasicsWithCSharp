using System;

namespace _7_Even__Odd_Positions
{
    class Program
    {
        static void Main()
        {
            //Si no hay ningún elemento mínimo / máximo, escriba "No" .
            Console.Write("ingrese numero: ");
            int n = int.Parse(Console.ReadLine());
   
            double sumaPar   = 0;
            double SumaImpar = 0;
            var maxImpar     = double.MinValue;
            var minImpar     = double.MaxValue;
            var maxPar       = double.MinValue;
            var minPar       = double.MaxValue;
           
            for (int i = 1; i <= n; i++)
            {
                double numero = double.Parse(Console.ReadLine());
                
                if (i % 2 == 0)
                {
                    if (numero > maxPar)
                    {
                        maxPar = numero;
                    }
                    if (numero < minPar)
                    {
                        minPar = numero;
                    }
                    sumaPar += numero;
                }
                else
                {
                    if (numero > maxImpar)
                    {
                        maxImpar = numero;
                    }
                    if (numero < minImpar)
                    {
                        minImpar = numero;
                    }
                    SumaImpar += numero;
                }
                
            }

            if (n == 0 || sumaPar == 0)
            {
                Console.WriteLine("Suma impar: " + SumaImpar);
                Console.WriteLine("Mínimo Impar: " + minImpar);
                Console.WriteLine("Máximo Impar: " + maxImpar);
                Console.WriteLine(" ");
                Console.WriteLine("Suma par: " + sumaPar);
                Console.WriteLine("Mínimo par: No");
                Console.WriteLine("Máximo par: No" );
           

            }
            else
            {
                Console.WriteLine("Suma impar: " + SumaImpar);
                Console.WriteLine("Mínimo Impar: " + minImpar);
                Console.WriteLine("Máximo Impar: " + maxImpar);
                Console.WriteLine(" ");
                Console.WriteLine("Suma par: " + sumaPar);
                Console.WriteLine("Mínimo par: " + minPar);
                Console.WriteLine("Máximo par: " + maxPar);
            }
            //Detener el prog, borrar y retornar al metodo main "inicio"
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
