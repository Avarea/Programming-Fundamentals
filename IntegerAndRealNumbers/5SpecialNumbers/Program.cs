using System;


namespace _5SpecialNumbers
{
    class Program
    {
        static void Main()
        {
            int maxNumber = int.Parse(Console.ReadLine());


            for (int i = 1; i <= maxNumber; i++)
            {
                foreach (var symbol in i.ToString())
                {
                    int maxSum = 0;
                    maxSum += symbol;
                    bool isSpecial = maxSum == 5 || maxSum == 7 || maxSum == 11;
                    Console.WriteLine($"{i} -> {isSpecial}");
                }
            }
        }
    }
}
