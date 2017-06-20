using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> newList = new List<int>();

            for (int cnt = 0; cnt < numbers.Count; cnt++)
            {
                if (numbers[cnt] > 0)
                {
                    newList.Add(numbers[cnt]);
                }
            }
            newList.Reverse();
            if (newList.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", newList));

            }
        }
    }
}
