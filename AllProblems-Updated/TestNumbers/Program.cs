using System;

namespace TestNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());
            int combinationsCounter = 0;
            int sum = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (sum >= maxSum)
                    {
                        break;
                    }
                    combinationsCounter++;
                    sum += (i * j) * 3;
                }
            }
            if (sum >= maxSum)
            {
                Console.WriteLine($"{combinationsCounter} combinations");
                Console.WriteLine($"Sum: {sum} >= {maxSum}");
            }
            else
            {
                Console.WriteLine($"{combinationsCounter} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
