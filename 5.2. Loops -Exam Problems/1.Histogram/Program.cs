using System;

namespace _1.Histogram
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingresar numero:  ");
            int n = int.Parse( Console.ReadLine() );

            //variables para llenar con los porcentajes
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

          

            int numeroPorGrupoP1 = 0;
            int numeroPorGrupoP2 = 0;
            int numeroPorGrupoP3 = 0;
            int numeroPorGrupoP4 = 0;
            int numeroPorGrupoP5 = 0;

            Console.WriteLine("rango [1...1000]");
            for (int i = 0; i < n; i++)
            {
               
                int numeroActual = int.Parse(Console.ReadLine());
               
                if (numeroActual < 200)
                {
                    numeroPorGrupoP1 ++;
                }
                else if(numeroActual >= 200 & numeroActual <= 399)
                {
                    numeroPorGrupoP2 ++;
                }
                else if (numeroActual >= 400 && numeroActual <= 599)
                {
                    numeroPorGrupoP3 ++;
                }
                else if (numeroActual >= 600 && numeroActual <= 799)
                {
                    numeroPorGrupoP4++;
                }
                else
                {
                    numeroPorGrupoP5++;
                }
            }

                p1 = numeroPorGrupoP1 * 100.0 / n;
                p2 = numeroPorGrupoP2 * 100.0 / n;
                p3 = numeroPorGrupoP3 * 100.0 / n;
                p4 = numeroPorGrupoP4 * 100.0 / n;
                p5 = numeroPorGrupoP5 * 100.0 / n;
            

            Console.WriteLine("{0}%", Math.Round(p1, 2));
            Console.WriteLine("{0}%", Math.Round(p2, 2));
            Console.WriteLine("{0}%", Math.Round(p3, 2));
            Console.WriteLine("{0}%", Math.Round(p4, 2));
            Console.WriteLine("{0}%", Math.Round(p5, 2));


            //Detener el prog, borrar y retornar al metodo main "inicio"
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
