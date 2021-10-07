using System;

namespace _2_Min_Method__Return_the_Smaller_Number_
{
    class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            var min = GetMin(GetMin(num1, num2), num3);

            Console.WriteLine($"Minimo: {min}");
        }


        static int GetMin(int a, int b)
        {
          return  Math.Min(a,b);
   
        }
    }
}
