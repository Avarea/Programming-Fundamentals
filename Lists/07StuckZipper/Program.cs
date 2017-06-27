using System;
using System.Collections.Generic;
using System.Linq;

namespace _07StuckZipper
{
    class Program
    {
        static void Main()
        {
            List<int> list1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> FirstLetterAfterRemoval = new List<int>();
            List<int> SecondLetterAfterRemoval = new List<int>();

            int FirstLetterMinDigit = CalculateMaxDigit(list1);
            int SecondLetterMinDigit = CalculateMaxDigit(list2);
            int MinDigit = Math.Min(FirstLetterMinDigit, SecondLetterMinDigit);

            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i] / MinDigit <= 0) FirstLetterAfterRemoval.Add(list1[i]);
            }
            for (int i = 0; i < list2.Count; i++)
            {
                if (list2[i] / MinDigit <= 0) SecondLetterAfterRemoval.Add(list2[i]);
            }
            int MaxLenght = Math.Max(FirstLetterAfterRemoval.Count, SecondLetterAfterRemoval.Count);

            List<int> CombineLetter = new List<int>();
            for (int i = 0; i < MaxLenght; i++)
            {
                if (i < SecondLetterAfterRemoval.Count) CombineLetter.Add(SecondLetterAfterRemoval[i]);
                if (i < FirstLetterAfterRemoval.Count) CombineLetter.Add(FirstLetterAfterRemoval[i]);
            }
            Console.WriteLine(string.Join(" ", CombineLetter));

        }
        private static int CalculateMaxDigit(List<int> Letter)
        {
            int mindigit = int.MaxValue;
            for (int i = 0; i < Letter.Count; i++)
            {
                int currentdigit = 1;
                int temp = Math.Abs(Letter[i]);
                while (true)
                {
                    if (temp / 10 == 0) break;
                    else
                    {
                        currentdigit *= 10;
                        temp = temp / 10;
                    }
                }
                mindigit = Math.Min(mindigit, currentdigit);
            }
            return mindigit * 10;
        }
    }
}
