using System;

namespace NeighbourWars
{
    class Program
    {
        static void Main()
        {
            int peshoDmg = int.Parse(Console.ReadLine());
            int goshoDmg = int.Parse(Console.ReadLine());

            int peshoHealth = 100;
            int goshoHealth = 100;

            for (int i = 1; i < int.MaxValue; i++)
            {
                if (i % 2 != 0)
                {
                    goshoHealth -= peshoDmg;
                    if (goshoHealth <= 0)
                    {
                        Console.WriteLine($"Pesho won in {i}th round.");
                        return;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                }
                else
                {
                    peshoHealth -= goshoDmg;
                    if (peshoHealth <= 0)
                    {
                        Console.WriteLine($"Gosho won in {i}th round.");
                        return;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                }
                if (i % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
            }
        }
    }
}
