﻿using System;


namespace _02CirclePerimeter
{
    class Program
    {
        static void Main()
        {
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f12}", Math.PI * radius * radius);
        }
    }
}
