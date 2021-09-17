using System;

namespace USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double BGN = 1;
            double USD = 1.79549;
            double EUR = 1.95583;
            double GBP = 2.53405;

            Console.WriteLine("Convert this money");
            double suma = double.Parse(Console.ReadLine());


            Console.WriteLine("Choose  input: 1=USD to BGN , 2=USD to BGN,  3=USD to BGN , 4=USD to BGN ");
            switch (double.Parse(Console.ReadLine()))
            {
                
                case 1:
                    Console.WriteLine("Input: USD to BGN = " + suma);
                    Console.WriteLine("OutPut: " + Math.Round( suma * USD /BGN,2) );
                    break;
                case 2:
                    Console.WriteLine("Input: BGN to EUR = " + suma);
                    Console.WriteLine("OutPut: " + Math.Round(suma * BGN / EUR, 2));
                    break;
                case 3:
                    Console.WriteLine("Input: EUR to GBP = " + suma);
                    Console.WriteLine("OutPut: " + Math.Round(suma * EUR / GBP, 2));
                    break;
                case 4:
                    Console.WriteLine("Input: USD to EUR = " + suma);
                    Console.WriteLine("OutPut: " + Math.Round(suma * USD / EUR, 2));
                    break;

                default:
                    
                    break;
            }
            //Console.WriteLine("Convertir a : ");
            //switch (double.Parse(Console.ReadLine()))
            //{
            //    case 1:
            //        Console.WriteLine("BGN :" + suma );
            //        break;
            //    case 2:

            //        Console.WriteLine("USD :" + (suma  * USD) / USD);
            //        break;
            //    case 3:
            //        Console.WriteLine("EUR :" + suma  / EUR);
            //        break;
            //    case 4:
            //        Console.WriteLine("GBP :" + suma / GBP);
            //        break;

            //    default:
            //        Console.WriteLine("null");
            //        break;
            //}



        }



    }
}
