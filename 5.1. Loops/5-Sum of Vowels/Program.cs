using System;

namespace _5_Sum_of_Vowels
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("**Sum of Vowels** \n");

            Console.Write("palabra: ");
            var bocal_loop = Console.ReadLine();
            int suma = 0;
            for (int i = 0; i < bocal_loop.Length; i++)
            {
                if (bocal_loop[i] == 'a')
                {
                    
                    suma += 1;
                }
                else if (bocal_loop[i] == 'e')
                {
                    
                    suma += 2;
                }
                else if (bocal_loop[i] == 'i')
                {
                    
                    suma += 3;
                }
                else if (bocal_loop[i] == 'o')
                {
                   
                    suma += 4;
                }
                else if (bocal_loop[i] == 'u')
                {
                   
                    suma += 5;
                }
            }
            Console.WriteLine(" :" + suma);


            //Detener el prog, borrar y retornar al metodo main "inicio"
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
