using System;
using System.Collections.Generic;
using System.Linq;

namespace TearListInHalf
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine()?.Split(' ').Select(int.Parse).ToList();
            List<int> leftHalf = new List<int>();
            List<int> rightHalf = new List<int>();

            for (int cnt = 0; cnt < input.Count; cnt++)
            {
                if (cnt < input.Count / 2)
                {
                    leftHalf.Add(input[cnt]);
                }
                else
                {
                    rightHalf.Add(input[cnt]);
                }
            }

            List<int> result = new List<int>();
            for (int i = 0; i < rightHalf.Count; i++)
            {
                result.Add(rightHalf[i] / 10);
                result.Add(leftHalf[i]);
                result.Add(rightHalf[i] % 10);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
