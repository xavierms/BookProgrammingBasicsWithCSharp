using System;

namespace Daily_Earnings
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Dias laborales: ");
            double diasLaboralesMEs = double.Parse(Console.ReadLine());
            Console.Write("Ganancias Diarias");
            double gananciasDiarias = double.Parse(Console.ReadLine());
            Console.Write("DE USD a EUR: ");
            double cambioUSDaEUR = double.Parse(Console.ReadLine());




            double salarioMensual = diasLaboralesMEs * gananciasDiarias;
            double IngresoAnual = (salarioMensual * 12) + (salarioMensual * 2.5) ;
            double imp = 0.25 * IngresoAnual;
            double ingresoAnualNetoUSD = IngresoAnual - imp;
            double ingresoAnualNetoEUR = ingresoAnualNetoUSD * cambioUSDaEUR;
            double GanaciasMediasDias = ingresoAnualNetoEUR /365;
            Console.WriteLine("Ganacias diarias: " + GanaciasMediasDias);
        }
    }
}
