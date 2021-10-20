using System;

namespace _2_Numerical_Expression
{
    class Program
    {
        static void Main()
        {
            int symbol = int.Parse( Console.ReadLine());

           
            decimal result = 0;
            int expresionOperator = '+';

            while (symbol != '=')
            {
                symbol = int.Parse(Console.ReadLine());
            }

            if (symbol == '(')
            {
                decimal innerResult = 0;
                int innerOperator = '+';
                symbol = int.Parse(Console.ReadLine());
            }
            else if (0 <= symbol - '0' && symbol - '0' <= 9)
            {
                switch (expresionOperator)
                {
                    case '+':
                        result += symbol - '0';
                        break;
                    case '-':
                        result -= symbol - '0';
                        break;
                    case '*':
                        result *= symbol - '0';
                        break;
                    case '/':
                        result /= symbol - '0';
                        break;
                    default:
                        break;
                }
            }
            else if (symbol == '+' || 
                     symbol == '-' || 
                     symbol == '/' || 
                     symbol == '*' )
            {
                expresionOperator = symbol;
            }
            switch (expresionOperator)
            {
                case '+':
                    result += inner;
                    break;
                case '-':
                    result -= symbol - '0';
                    break;
                case '*':
                    result *= symbol - '0';
                    break;
                case '/':
                    result /= symbol - '0';
                    break;
                default:
                    break;
            }

            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
