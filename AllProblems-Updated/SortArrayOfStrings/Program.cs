﻿using System;
using System.Linq;

namespace SortArrayOfStrings
{
    class Program
    {
        static void Main()
        {
            string[] arrayOfStrings = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                for (int sort = 0; sort < arrayOfStrings.Length - 1; sort++)
                {
                    string first = arrayOfStrings[sort];
                    string second = arrayOfStrings[sort + 1];

                    if (first.CompareTo(second) > 0)
                    {
                        arrayOfStrings[sort] = second;
                        arrayOfStrings[sort + 1] = first;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", arrayOfStrings));
        }

    }
}
