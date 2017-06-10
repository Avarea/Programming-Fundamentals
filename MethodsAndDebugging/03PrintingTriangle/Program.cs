using System;

namespace _03PrintingTriangle
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int start = 1;
            int end = n;



            for (int i = start; i < n; i++)
            {
                PrintLine(1, i);
            }
            PrintLine(1, n);

            for (int j = end - 1; j >= 0; j--)
            {
                PrintLine(1, j);
            }
        }



        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
