using System;

namespace _04DrawAFilledSquare
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintSide(n);
            PrintBody(n);
            PrintSide(n);
        }

         static void PrintBody(int n)
        {
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write('-');
                for (int j = 1; j < n; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }

        }

        static void PrintSide(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }
    }
}
