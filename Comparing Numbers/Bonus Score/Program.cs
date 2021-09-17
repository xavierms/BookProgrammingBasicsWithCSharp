using System;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insertar número: ");
            double number = int.Parse(Console.ReadLine());
            double Bonus_Score = 0.0;
            double accrued = 0;

            if(number % 10 == 5)
            {
                Bonus_Score += 2;
            }
            else if(number < 1000)
            {
                Bonus_Score += 1;
            }
            if (number <=100)
            {
                double init = 5;
                accrued =Bonus_Score +  init ;
            }
                     
            if (number > 1000 )
            {
                accrued= Bonus_Score + (number * 0.10) ;
             }
            else if(number > 100)
            {
                accrued =Bonus_Score + (number * 0.20);
            }
            Console.WriteLine($"Bonus score  = {accrued}");
            Console.WriteLine($"Accrued = {accrued + number}");
        }
       
    }
}
