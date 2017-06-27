using System;
using System.Collections.Generic;
using System.Linq;

namespace _03EqualSumAfterExtraction
{
    class Program
    {
        static void Main()
        {
            List<int> list1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int list1Sum = 0;
            int list2Sum = 0;

            for (int i = 0; i < list1.Count; i++)
            {
                for (int j = 0; j < list2.Count; j++)
                {
                    if (list1[i] == list2[j])
                    {
                        list2.Remove(list2[j]);
                    }
                }   
            }
            for (int i = 0; i < list1.Count; i++)
            {
                list1Sum += list1[i];
            }
            for (int i = 0; i < list2.Count; i++)
            {
                list2Sum += list2[i];

            }
            if (list1Sum == list2Sum)
            {
                Console.WriteLine($"Yes. Sum: {list1Sum}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(list1Sum - list2Sum)}");
            }
        }
    }
}
