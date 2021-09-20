using System;

namespace TriangleOf55Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int value =5;
            for (int j = 0; j >= -10; j--)
            {
                
                Console.WriteLine(new string('*', j));

            }
            for (int i = 1; i <= 10; i++)
            {
               
                Console.WriteLine(new string('*', i)); 
               
            }
           
        }  
    }
}
