using System;

namespace Notifications
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "success":
                        string operation = Console.ReadLine();
                        string message = Console.ReadLine();
                        ShowSuccess(operation, message);
                        break;
                    case "error":
                        operation = Console.ReadLine();
                        int code = int.Parse(Console.ReadLine());
                        ShowError(operation, code);
                        break;
                }
            }
        }

         static void ShowError(string operation, int code)
        {
            Console.WriteLine($"Error: Failed to execute {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Error Code: {code}.");
            string reason = string.Empty;
            if (code > 0)
            {
                reason = "Invalid Client Data";
            }
            else
            {
                reason = "Internal System Failure";
            }
            Console.WriteLine($"Reason: {reason}.");
        }

         static void ShowSuccess(string operation, object message)
        {
            Console.WriteLine($"Successfully executed {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Message: {message}.");
        }
    }
}
