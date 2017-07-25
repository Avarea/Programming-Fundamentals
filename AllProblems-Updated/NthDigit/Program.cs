using System;

namespace NthDigit
{
    class Program
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine(FindNthDigit(number, index));
        }

         static long FindNthDigit(long number, int index)
        {
            int currentIndex = 1;
            while (number > 0)
            {
                if (currentIndex == index)
                {
                    return number % 10;
                }
                else
                {
                    number = number / 10;
                    currentIndex++;
                }
            }
            return number;
        }
    }
}
