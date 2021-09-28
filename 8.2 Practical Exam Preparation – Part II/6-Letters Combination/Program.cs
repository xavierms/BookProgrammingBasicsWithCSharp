using System;

namespace _6_Letters_Combination
{
    class Program
    {
        static void Main()
        {

            char starLetter   = char.Parse(Console.ReadLine());
            char endLetter    = char.Parse(Console.ReadLine());
            char exceptletter = char.Parse(Console.ReadLine());

           
            int count = 0;

            for (char i = starLetter; i <= endLetter; i++)
            {
                if (i != exceptletter)
                {
                    
                    for (char j = starLetter; j <= endLetter; j++)
                    {
                        if (j != exceptletter)
                        {
                            
                            for (char k = starLetter; k <= endLetter; k++)
                            {
                                if (k != exceptletter)
                                {
                                    count++;                                    
                                    Console.Write($"{i}{j}{k} " + " " );
                                    
                                   
                                }
                            }
                        }
                    }
               }
               
            }
            Console.WriteLine(count);


            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
