using System;
using System.Collections.Generic;
using System.Linq;

namespace StuckZipper
{
    class Program
    {
        static void Main()
        {
            List<int> firstList = Console.ReadLine()?.Split(' ').Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine()?.Split(' ').Select(int.Parse).ToList();

            int minLenght = FindMinLenghtNumber(firstList, secondList);

            List<int> firstFilteredList = new List<int>();
            List<int> secondFilteredList = new List<int>();

            for (int cnt = 0; cnt < firstList.Count; cnt++)
            {
                if (FindNumberLenght(firstList[cnt]) <= minLenght)
                {
                    firstFilteredList.Add(firstList[cnt]);
                }
            }

            for (int cnt = 0; cnt < secondList.Count; cnt++)
            {
                if (FindNumberLenght(secondList[cnt]) <= minLenght)
                {
                    secondFilteredList.Add(secondList[cnt]);
                }
            }

            List<int> result = new List<int>();
            for (int cnt = 0; cnt < Math.Max(firstFilteredList.Count, secondFilteredList.Count); cnt++)
            {
                if (cnt < secondFilteredList.Count)
                {
                    result.Add(secondFilteredList[cnt]);
                }
                if (cnt < firstFilteredList.Count)
                {
                    result.Add(firstFilteredList[cnt]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }

        static int FindMinLenghtNumber(List<int> firstList, List<int> secondList)
        {
            int minLenght = int.MaxValue;
            for (int cnt = 0; cnt < firstList.Count; cnt++)
            {
                if (minLenght > FindNumberLenght(firstList[cnt]))
                {
                    minLenght = FindNumberLenght(firstList[cnt]);
                }
            }

            for (int cnt = 0; cnt < secondList.Count; cnt++)
            {
                if (minLenght > FindNumberLenght(secondList[cnt]))
                {
                    minLenght = FindNumberLenght(secondList[cnt]);
                }
            }
            return minLenght;
        }

        private static int FindNumberLenght(int number)
        {
            int digitCount = 0;
            number = Math.Abs(number);
            while (number > 0)
            {
                digitCount++;
                number /= 10;
            }
            return digitCount;
        }
    }
}
