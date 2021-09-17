using System;

namespace _16_Numbers_from_0_to_100_as_English_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Input number from 0 to 100:  ");
            int number = int.Parse(Console.ReadLine());
            
            int decenas = number / 10;
            //DECENAS 20-0
            if (decenas == 2)
            {
                Console.Write("Twenty ");
            }
            if (decenas == 3)
            {
                Console.Write("Thirty ");
            } 
            if (decenas == 4)
            {
                Console.Write("Forty ");
            }
            if (decenas == 5)
            {
                Console.Write("Fifty ");
            }
            if (decenas == 6)
            {
                Console.Write("Sixty ");
            }
            if (decenas == 7)
            {
                Console.Write("Thirty ");
            }
            if (decenas == 8)
            {
                Console.Write("Eighty ");
            }
            if (decenas == 9)
            {
                Console.Write("Ninety ");
            }
            if (number == 100 )
            {
                Console.WriteLine("One hundred");
            }
            else if(number > 100)
            {
                Console.WriteLine("Most be less to 100!!");
            }
          


            //10 to 19
            if (number ==10)
            {
                Console.WriteLine("Ten");
            }         if (number == 11 )
            {
                Console.WriteLine("Eleven");
            }         if (number ==12)
            {
                Console.WriteLine("Twelve");
            }         if (number ==13)
            {
                Console.WriteLine("Thirteen");
            }         if (number ==14)
            {
                Console.WriteLine("Fourteen");
            }         if (number ==15)
            {
                Console.WriteLine("Fifteen");
            }          if (number ==16)
            {
                Console.WriteLine("Sixteen");
            }          if (number ==17)
            {
                Console.WriteLine("Seventeen");
            }          if (number ==18)
            {
                Console.WriteLine("Eighteen");
            }          if (number ==19)
            {
                Console.WriteLine("Nineteen");
            }
            else
            {
                Console.ReadKey();
            }

            int oneDigit = number % 10;
            // 0 to 9
            if (number == 0)
            {
                Console.WriteLine("Zero");
            }
            if (number == 1 || oneDigit == 1)
            {
                Console.WriteLine("One");
            } if (number == 2 || oneDigit == 2)
            {
                Console.WriteLine("Two");
            } if (number == 3 || oneDigit ==  3)
            {
                Console.WriteLine("Three");
            } if (number == 4 || oneDigit == 4)
            {
                Console.WriteLine("Four");
            } if (number == 5 || oneDigit ==  5)
            {
                Console.WriteLine("Five");
            } if (number == 6 || oneDigit ==  6)
            {
                Console.WriteLine("Six");
            } if (number == 7 || oneDigit ==  7)
            {
                Console.WriteLine("Seven");
            } if (number == 8 || oneDigit ==  8)
            {
                Console.WriteLine("Eight");
            } if (number == 9 || oneDigit ==  9)
            {
                Console.WriteLine("Nine");
            }
            
          
        }
    }
}
