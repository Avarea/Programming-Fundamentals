using System;

namespace MagicLetter
{
    class Program
    {
        static void Main()
        {
            char start = char.Parse(Console.ReadLine());
            char finish = char.Parse(Console.ReadLine());
            char isThisMagic = char.Parse(Console.ReadLine());

            for (char i = start; i <= finish; i++)
            {
                if (i == isThisMagic)
                {
                    continue;
                }
                for (char j = start; j <= finish; j++)
                {
                    if (j == isThisMagic)
                    {
                        continue;
                    }
                    for (char k = start; k <= finish; k++)
                    {
                        if (k == isThisMagic)
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
