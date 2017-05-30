using System;

namespace _14MagicLetter
{
    class Program
    {
        static void Main()
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char magicLetter = char.Parse(Console.ReadLine());

            for (char i = firstLetter; i <= secondLetter; i++)
            {
                if (i == magicLetter)
                {
                    continue;
                }
                for (char j = firstLetter; j <= secondLetter; j++)
                {
                    if (j == magicLetter)
                    {
                        continue;
                    }
                    for (char k = firstLetter; k <= secondLetter; k++)
                    {
                        if (k == magicLetter)
                        {
                            continue;
                        }
                        Console.Write($"{i}{j}{k} ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
