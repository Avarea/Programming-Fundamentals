using System;

namespace AddTwoNumbers
{
    class Program
    {
        static void Main()
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"{number1} + {number2} = {GetSum(number1, number2)}");
        }

        private static double GetSum(double number1, double number2)
        {
            return number1 + number2;
        }
    }
}
