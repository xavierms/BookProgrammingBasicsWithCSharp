using System;
using System.Collections.Generic;
using System.Linq;

namespace _4_Grades
{
    class Program
    {
        static void Main()
        {
            Console.Write("Cantidad de estudiantes: ");
            double n = double.Parse(Console.ReadLine());

            List<double> count = new List<double>();
            double acu = 0;
            double A = 0;
            double B = 0;
            double C = 0;
            double F = 0;

            for (int i = 0; i < n; i++)
            {
                double calificacionExamen = double.Parse( Console.ReadLine() );
                 if (calificacionExamen >= 5)
                {
                    A++;

                    //"Next highest");
                }
                else if (calificacionExamen >= 4.00 || calificacionExamen >= 4.99)
                {
                    B++;
                    //"Average performance");
                } 
                else if (calificacionExamen >= 3.00 || calificacionExamen >= 3.99)
                {
                    C++;
                    //"Lowest passing grade");
                }
                else if(calificacionExamen < 3 )
                {
                    F++;
                    //"Failing grade");
                }
                count.Add(calificacionExamen);
                acu = count.Sum();
            }
            double NextHighest        = Math.Round( (A * 100) / n, 2);
            double AveragePerformance = Math.Round( (B * 100) / n, 2);
            double LowestPassingGrade = Math.Round( (C * 100) / n, 2);
            double FailingGrade       = Math.Round( (F * 100) / n, 2);

            double promedio =Math.Round( acu / n,2);
            //   double calificacionPromedio = count / CantidadEstudiantes; 

            Console.WriteLine($"Alumnos superiores: {NextHighest} %" +
                $"\n Entre 4,00 y 4,99: {AveragePerformance} %" +
                $"\n Entre 3,00 y 3,99: {LowestPassingGrade} %" +
                $"\n Reprobado: {FailingGrade}  %" +
                $"\n Promedio: {promedio} ");

            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
