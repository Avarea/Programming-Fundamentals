using System;

namespace _08SumOfOddNumbers
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;

            for (int i = 1; ; i++)
            {
                if (i % 2 == 1)
                {
                    count++;
                    sum += i;
                    Console.WriteLine(i);
                }

                if (count == num)
                {
                    break;
                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
