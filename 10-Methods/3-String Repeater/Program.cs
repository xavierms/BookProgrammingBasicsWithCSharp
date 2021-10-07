using System;

namespace _3_String_Repeater
{
    class Program
    {
        static void Main(string[] args)
        {
            var strInput   = Console.ReadLine();
            int countInput = int.Parse( Console.ReadLine() );

            RepeatString(strInput,countInput);
          
        }
       static string RepeatString(string str, int count)
        {
            var repeatedString = string.Empty; ;
            for (int i = 0; i < count; i++)
            {
                Console.Write(str);
            }
            return repeatedString;
        }
    }
}
