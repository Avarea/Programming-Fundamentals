﻿using System;

namespace _08CaloriesCounter
{
    class Program
    {
        static void Main()
        {
            int counter = int.Parse(Console.ReadLine());
            int calories = 0;

            for (int i = 1; i <= counter; i++)
            {
                string ingredient = Console.ReadLine().ToLower();
                switch (ingredient)
                {
                    case "cheese":
                        calories += 500;
                        break;
                    case "tomato sauce":
                        calories += 150;
                        break;
                    case "salami":
                        calories += 600;
                        break;
                    case "pepper":
                        calories += 50;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("Total calories: {0}", calories);
        }
    }
}
