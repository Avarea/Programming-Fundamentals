using System;
using System.Linq;

namespace _04UnunionLists
{
    class Program
    {
        static void Main()
        {
            var primalList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int nLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < nLines; i++)
            {
                var numbersToAdd = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                for (int v = 0; v < numbersToAdd.Count; v++)
                {
                    if (primalList.Contains(numbersToAdd[v]))
                    {
                        primalList.RemoveAll(x => x == numbersToAdd[v]);
                    }
                    else
                    {
                        primalList.Add(numbersToAdd[v]);
                    }
                }
            }
            primalList.Sort();
            Console.WriteLine(string.Join(" ", primalList));
        }
    }
}
