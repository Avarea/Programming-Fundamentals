using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02ArrayElementsEqualToTheirIndex
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == numbers[i])
                {
                    Console.Write("{0} ",numbers[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
