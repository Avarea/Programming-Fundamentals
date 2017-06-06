using System;

namespace _15Calculator
{
    class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            string operatorR = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            switch (operatorR)
            {
                case "+":
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;
                case "/":
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    break;
                default:
                    break;
            }
        }
    }
}
