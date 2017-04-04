using System;


namespace _5SpecialNumbers
{
    class Program
    {
        static void Main()
        {
            int maxNumber = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= maxNumber; i++)
            {
                int maxSum = 0;
                foreach (var symbol in i.ToString())
                {

                    maxSum += symbol - '0';
                    sum = maxSum;
                }

                bool isSpecial = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
