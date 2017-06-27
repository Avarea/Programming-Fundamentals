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
            List<int> combined = new List<int>();

            int smallestList1 = Int32.MaxValue;
            for (int i = 0; i < list1.Count; i++)
            {
                if (smallestList1 > list1[i])
                {
                    smallestList1 = list1[i];
                }
            }
            int smallestDigit1 = smallestList1.ToString().Length;
            for (int i = 0; i < list1.Count; i++)
            {
                if (smallestDigit1 < list1[i].ToString().Length)
                {
                    list1.Remove(list1[i]);
                }
            }


            int smallestList2 = Int32.MaxValue;
            for (int i = 0; i < list2.Count; i++)
            {
                if (smallestList2 > list2[i])
                {
                    smallestList2 = list2[i];
                }
            }
            int totalSmallest = 0;
            if (smallestList1 < smallestList2)
            {
                totalSmallest = smallestList1;
            }
            else
            {
                totalSmallest = smallestList2;
            }
            totalSmallest = totalSmallest.ToString().Length;
            for (int i = 0; i < list1.Count; i++)
            {

                if (totalSmallest < list1[i].ToString().Length)
                {
                    list1.Remove(list1[i]);
                }
            }

            for (int i = 0; i < list2.Count; i++)
            {

                if (totalSmallest < list2[i].ToString().Length)
                {
                    list2.Remove(list2[i]);
                }
            }
            for (int i = 0; i < combined.Count; i++)
            {
                combined.Add(list2[i]);
                combined.Add(list1[i]);
            }



            Console.WriteLine(string.Join(" ", list1));
            Console.WriteLine(string.Join(" ", list2));
        }
    }
}
