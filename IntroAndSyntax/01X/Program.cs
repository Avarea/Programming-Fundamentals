using System;

namespace _01X
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int topSpaces = n - 2;
            int topStart = 0;
            for (int i = 1; i <= n / 2; i++)
            {

                Console.WriteLine("{0}x{1}x{0}", new string(' ', topStart), new string(' ', topSpaces));
                topSpaces = topSpaces - 2;
                topStart++;
            }
            Console.WriteLine("{0}x{0}", new string(' ', (n - 1) / 2));

            int botSpaces = 1;
            int botStart = (n - 3) / 2;

            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}x{1}x{0}", new string(' ', botStart), new string(' ', botSpaces));
                botSpaces += 2;
                botStart--;
            }
        }
    }
}
