﻿using System;


namespace _20.DebuggingTriangleFormations
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            var triangleValidityCondition1 = a + b > c;
            var triangleValidityCondition2 = b + c > a;
            var triangleValidityCondition3 = a + c > b;

            var rightTriangleCondition1 = a * a + b * b == c * c;
            var rightTriangleCondition2 = b * b + c * c == a * a;
            var rightTriangleCondition3 = a * a + c * c == b * b;


            bool isValidTriangle = triangleValidityCondition1 && triangleValidityCondition2 && triangleValidityCondition3;

            if (isValidTriangle)
            {
                Console.WriteLine("Triangle is valid.");
                if (rightTriangleCondition1)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and b");

                }
                else if (rightTriangleCondition2)
                {
                    Console.WriteLine("Triangle has a right angle between sides b and c");

                }
                else if (rightTriangleCondition3)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and c");

                }
                else
                {
                    Console.WriteLine("Triangle has no right angles.");

                }
            }
            else
            {
                Console.WriteLine("Invalid Triangle.");
            }




        }
    }
}
