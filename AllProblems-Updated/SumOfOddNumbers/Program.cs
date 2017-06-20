using System;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            GetOddNumbers(n);
        }

        private static void GetOddNumbers(int n)
        {
            int sum = 0;
            int counter = 0;
            for (int j = 1; j < int.MaxValue; j+=2)
            {
                Console.WriteLine(j);
                sum += j;
                counter++;
                if (counter == n)
                {
                    Console.WriteLine("Sum: {0}", sum);
                    break;
                }
            }
        }
    }
}
