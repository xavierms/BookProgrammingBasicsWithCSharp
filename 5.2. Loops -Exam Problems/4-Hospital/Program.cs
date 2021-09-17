using System;

namespace _4_Hospital
{
    class Program
    {
        static void Main()
        {
            Console.Write("Periodo: ");
            int periodoTiempo = int.Parse(Console.ReadLine());


            int pacientesTratados   = 0;
            int pacientesNOtratados = 0;
            int medicos = 7;

            for (int i = 1; i <= periodoTiempo; i++)
            {

               int pacientes = int.Parse( Console.ReadLine() );

                if (i % 3 == 0)
                {
                    if (pacientes > medicos)
                    {
                        //cada 3 dias se incremente un doctor
                        medicos++;
                    } 
                }

                if (pacientes > medicos)
                {
                    pacientesTratados += medicos;
                    pacientesNOtratados += pacientes - medicos;
                }
                else
                {
                    pacientesTratados += pacientes;
                }


            }

            
            Console.WriteLine($"pacientes tratados { pacientesTratados }");
            Console.WriteLine($"pacientes NO tratados { pacientesNOtratados }");

            //Detener el prog, borrar y retornar al metodo main "inicio"
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
