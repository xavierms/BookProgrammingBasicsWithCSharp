using System;

namespace Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Precio de vegetales: ");
            double Vegetableprice   = double.Parse(Console.ReadLine());

            Console.WriteLine("Precio de frutas");
            double Fruitprice       = double.Parse(Console.ReadLine());

            Console.WriteLine("Kg de vegetales: ");
            double TotalKgVegetable = double.Parse(Console.ReadLine());

            Console.WriteLine("Kg de frutas: ");
            double TotalKgFruits    = double.Parse(Console.ReadLine());
            


            double EUR = 1.94;
            double costoVege  = Vegetableprice * TotalKgVegetable;
            double costoFruit = Fruitprice * TotalKgVegetable;
            double total = costoVege + costoFruit / EUR;

            Console.WriteLine("Total: {0} EUR" , total);
        }
    }
}
