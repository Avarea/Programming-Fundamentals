using System;

namespace _06Notifications
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string command = Console.ReadLine();
                if (command == "success")
                {
                    string operation = Console.ReadLine();
                    string message = Console.ReadLine();
                    ShowSuccess(operation, message);
                }
                else if (command == "error")
                {
                    string operation = Console.ReadLine();
                    int code = int.Parse(Console.ReadLine());
                    ShowError(operation, code);
                }
                else
                {
                    continue;
                }
            }

        }

        static void ShowSuccess(string operation, string message)
        {
            Console.WriteLine($"Successfully executed {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Message: {message}.");
        }

        static void ShowError(string operation, int code)
        {
            string reason = null;
            if (code > 0)
            {
                reason = "Invalid Client Data";
            }
            else
            {
                reason = "Internal System Failure";
            }

            Console.WriteLine($"Error: Failed to execute {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Error Code: {code}.");
            Console.WriteLine($"Reason: {reason}.");
        }
    }
}
