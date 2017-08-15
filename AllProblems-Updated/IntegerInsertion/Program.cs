using System;
using System.Collections.Generic;
using System.Linq;

namespace IntegerInsertion
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine()?.Split(' ').Select(int.Parse).ToList();

            string number = Console.ReadLine();
            while (number != "end")
            {
                int index = int.Parse(number);
                while (index > 10)
                {
                    index /= 10;
                }
                input.Insert(index, int.Parse(number));
                number = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", input));
        }
    }
}
