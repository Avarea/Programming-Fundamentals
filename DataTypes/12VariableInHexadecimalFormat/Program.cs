﻿using System;

namespace _12VariableInHexadecimalFormat
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(input, 16));
        }
    }
}
