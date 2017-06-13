using System;

namespace _04NthDigit
{
    class Program
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine(FindNthDigit(number, index));

        }

        static int FindNthDigit(long number, int index)
        {
            int CurrentIndex = 1;

            while (number > 0)
            {
                if (index == CurrentIndex)
                {
                    return (int)number % 10;
                }
                else
                {
                    number = number / 10;
                }
                CurrentIndex++;
            }
            return (int)number;
        }
    }
}
