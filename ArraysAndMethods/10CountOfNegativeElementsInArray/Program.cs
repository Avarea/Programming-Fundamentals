﻿using System;


namespace _10CountOfNegativeElementsInArray
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
