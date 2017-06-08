using System;

namespace _09RefactorSpecialNumbers
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= input; i++)
            {
                bool isSpecial = false;
                int number = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{number} -> {isSpecial}");
                sum = 0;
                i = number;
            }
        }
    }
}
