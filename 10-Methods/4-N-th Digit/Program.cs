using System;
using System.Collections.Generic;
using System.Linq;

namespace _4_N_th_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int index  = int.Parse(Console.ReadLine());

            
            FindNthDigit(number, index);
            

        }
        static int FindNthDigit(int number, int index)
        {
            var ok = number.ToString();

            Console.WriteLine(ok[ok.Length - index]);
            return number;
        }
    }
}
