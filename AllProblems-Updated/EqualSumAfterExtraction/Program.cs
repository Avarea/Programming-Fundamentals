using System;
using System.Collections.Generic;
using System.Linq;

namespace EqualSumAfterExtraction
{
    class Program
    {
        static void Main()
        {
            List<int> list1 = Console.ReadLine()?.Split(' ').Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine()?.Split(' ').Select(int.Parse).ToList();

            for (int cnt = 0; cnt < list1.Count; cnt++)
            {
                for (int cnt2 = 0; cnt2 < list2.Count; cnt2++)
                {
                    if (list1[cnt] == list2[cnt2])
                    {
                        list2.RemoveAt(cnt2);
                        cnt2--;
                    }
                }
            }
            long sumList2 = list2.Sum();
            long sumList1 = list1.Sum();

            if (sumList1 == sumList2)
            {
                Console.WriteLine($"Yes. Sum: {Math.Abs(sumList1)}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(sumList1 - sumList2)}");
            }
        }
    }
}
