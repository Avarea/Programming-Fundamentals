using System;

namespace DebitCardNumber
{
    class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            GetNumber(num1, num2, num3, num4);
        }

        private static void GetNumber(int num1, int num2, int num3, int num4)
        {
            Console.WriteLine($"{num1:D4} {num2:D4} {num3:D4} {num4:D4}");
        }
    }
}
