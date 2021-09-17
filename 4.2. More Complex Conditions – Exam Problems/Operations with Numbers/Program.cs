using System;

namespace Operations_with_Numbers
{
    class Program
    {
        static void Main()
        {
            


            Console.WriteLine("**Operations with Numbers**");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("1er factor: ");
            double primer_factor = double.Parse(Console.ReadLine());

            Console.Write("2do factor: ");
            double segundo_factor = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserte el operador:  \n '+', '-', '*', '/', '%' ");
            var operadores_matematicos = Console.ReadLine();

            double result = 0;
           
            if (operadores_matematicos == "+")
            {
              result=  primer_factor + segundo_factor;
               // Console.WriteLine("Suma: {0}", result);
            }
            if (operadores_matematicos == "-")
            {
                result = primer_factor - segundo_factor;
                //Console.WriteLine("Resta: {0}", result);
            } 
            if (operadores_matematicos == "*")
            {
                result = primer_factor * segundo_factor;
               // Console.WriteLine("Multiplicación: {0}", result);
            } 

            if (operadores_matematicos == "/")
            {
                result = primer_factor / segundo_factor;
                Console.WriteLine($"{primer_factor} / {segundo_factor} = {String.Format("{0:0.00}", result)}");
            }
            if (operadores_matematicos == "%")
            {
                result = primer_factor % segundo_factor;
                Console.WriteLine($"{primer_factor} % {segundo_factor} = {result}");
            }

            //validaciones si es par o impar y si es 0 pno puede dividir
            if (operadores_matematicos == "+" || operadores_matematicos == "-" || operadores_matematicos == "*")
            {
                if (result % 2 == 0)
                {
                    
                    Console.Write(result + " - Par");
                }
                else
                {
                    Console.Write(result + " - Impar");
                }

            }
            if (segundo_factor == 0 && (operadores_matematicos == "/" || operadores_matematicos == "%"))
            {
                Console.WriteLine($"No se puede dividir {primer_factor} por cero  ");
            }

           //detener el prog, borrar y retornar al metodo main "inicio"
            Console.ReadKey();
            Console.Clear();
            Main();

           
        }
    }
}
