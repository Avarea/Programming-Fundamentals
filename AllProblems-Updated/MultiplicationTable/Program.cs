using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            GetTable(n);
        }

        private static void GetTable(int n)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{n} X {j} = {n * j}");
            }
        }
    }
}
