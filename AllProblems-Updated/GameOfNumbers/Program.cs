using System;

namespace GameOfNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int counter = 0;
            bool noMagicHere = false;

            for (int i = m; i >= n; i--)
            {
                for (int j = m; j >= n; j--)
                {
                    counter++;
                    if (i + j == magicNum)
                    {
                        Console.WriteLine($"Number found! {i} + {j} = {magicNum}");
                        return;
                    }
                    else
                    {
                        noMagicHere = true;
                    }
                }
            }
            if (noMagicHere)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
            }
        }
    }
}
