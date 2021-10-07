using System;

namespace _6_Notifications
{
    class Program
    {
        static void Main()
        {
            readAndProcessMessage();           

            Console.ReadKey();
            Console.Clear();
            Main();
        }
        static void ShowSuccesMessage(string operation, string message) 
        {
            operation = "Succesfully executed" + operation;
            Console.WriteLine(operation);
            Console.WriteLine(new string('=', operation.Length));
            Console.WriteLine(message);
        }
        static void ShowWarningMessage(string message) 
        {
            message = "Warning:" + message;
            Console.WriteLine(message);
            Console.WriteLine(new string('=', message.Length));
        }
        static void ShowErrorMessage(string operation, string message, int errorCode) 
        {
            operation = "Error: Failed to execute " + operation;
            Console.WriteLine(operation);
            Console.WriteLine(new string('=', operation.Length));
            Console.WriteLine($"Reason: {message}.");
            Console.WriteLine($"Error code: {errorCode}");
        }
        static void readAndProcessMessage()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var notificationType = Console.ReadLine();
                if (notificationType == "error")
                {
                    var operation = Console.ReadLine();
                    var message   = Console.ReadLine();
                    var errorCode = int.Parse(Console.ReadLine());

                    ShowErrorMessage(operation, message, errorCode);
                    
                }
                else if (notificationType == "warning")
                {
                    var message = Console.ReadLine();

                    ShowWarningMessage(message);
                }
                else if (notificationType == "success" )
                {
                    var operation = Console.ReadLine();
                    var message = Console.ReadLine();
                    ShowSuccesMessage(operation, message );
                }

            }
        }
    }
}
