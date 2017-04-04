using System;


namespace _9RefactorSpecialNumbers
{
    class Program
    {
        static void Main()
        {
            int maxNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            int currentNumber = 0;
            for (int i = 1; i <= maxNumber; i++)
            {
                currentNumber = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                bool isItSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{currentNumber} -> {isItSpecial}");
                sum = 0;
                i = currentNumber;
            }
        }
    }
}
