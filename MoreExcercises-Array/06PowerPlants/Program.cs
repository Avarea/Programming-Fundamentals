﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06PowerPlants
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] plants = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int alive = 0;
            int days = 0;
            int deaths = 0;



            for (int season = 0; season < int.MaxValue; season++)
            {
                for (int day = 0; day < plants.Length; day++)
                {
                    if (plants[day] > 0)
                    {
                        plants[day]++;
                    }
                    for (int plant = 0; plant < plants.Length; plant++)
                    {
                        plants[plant]--;
                    }
                    for (int checkAlive = 0; checkAlive < plants.Length; checkAlive++)
                    {
                        if (plants[checkAlive] > 0)
                        {
                            alive++;
                        }
                        else if (plants[checkAlive] <= 0)
                        {
                            deaths++;
                        }
                    }
                    days++;
                    if (alive == 0)
                    {
                        Console.WriteLine($"survived {days} days ({season} seasons)");
                        return;
                    }
                    alive = 0;
                    deaths = 0;
                }
                for (int bloom = 0; bloom < plants.Length; bloom++)
                {
                    if (plants[bloom] > 0)
                    {
                        plants[bloom]++;
                    }
                }
            }
        }
    }
}

