using System;

namespace _5_Division_without_Remainder
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingresar numero:  ");
            int n = int.Parse(Console.ReadLine());

            //variables para llenar con los porcentajes
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
        

            int numeroPorGrupoP1 = 0;
            int numeroPorGrupoP2 = 0;
            int numeroPorGrupoP3 = 0;
      

            Console.WriteLine("rango [1...1000]");
            for (int i = 0; i < n; i++)
            {
                int numeroActual = int.Parse(Console.ReadLine());

                if (numeroActual % 2 == 0)
                {
                    numeroPorGrupoP1++;
                }
                if (numeroActual % 3 == 0)
                {
                    numeroPorGrupoP2++;
                }
                if (numeroActual % 4 == 0)
                {
                    numeroPorGrupoP3++;
                }
               
            }

            p1 = numeroPorGrupoP1 * (100.0 / n);
            p2 = numeroPorGrupoP2 * (100.0 / n);
            p3 = numeroPorGrupoP3 * (100.0 / n);
            


            Console.WriteLine("{0}%", Math.Round(p1, 2));
            Console.WriteLine("{0}%", Math.Round(p2, 2));
            Console.WriteLine("{0}%", Math.Round(p3, 2));
            

            //Detener el prog, borrar y retornar al metodo main "inicio"
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
