using System;

namespace MultiplicationTable2._0
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            GetTable(n, multiplier);
        }

        private static void GetTable(int n, int multiplier)
        {
            do
            {
                Console.WriteLine($"{n} X {multiplier} = {n * multiplier}");
                multiplier++;
            } while (multiplier <= 10);
        }
    }
}
