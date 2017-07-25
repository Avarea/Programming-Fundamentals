using System;
using System.Collections.Generic;
using System.Linq;

namespace _02IntegerInsertion
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string check = Console.ReadLine();
            while (!check.Equals("end"))
            {
                int pos = int.Parse(check[0] + "");
                int num = int.Parse(check);
                numbers = NewArray(pos, num, numbers);


                check = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static int[] NewArray(int pos, int num, int[] flist)
        {
            int[] a = new int[flist.Length + 1];
            int index = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (i == pos)
                {
                    a[pos] = num;
                    a[i + 1] = flist[i];
                }
                else
                {
                    a[i] = flist[index];
                    index++;
                }
            }
            return a;
        }
    }
}
