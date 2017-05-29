using System;

namespace _10MultiplicationTable2._0
{
    class Program
    {
        static void Main()
        {
            int multiplier = int.Parse(Console.ReadLine());
            int start = int.Parse(Console.ReadLine());
            if (start > 10)
            {
                Console.WriteLine($"{multiplier} X {start} = {multiplier * start}");
            }
            else
            {
                for (int i = start; i <= 10; i++)
                {
                    Console.WriteLine($"{multiplier} X {i} = {multiplier * i}");
                }
            }
        }
    }
}
