using System;
using System.Linq;

namespace PowerPlants
{
    class Program
    {
        static void Main()
        {
            int[] plantLives = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int daysCount = 0;
            int daysInSeason = plantLives.Length;

            while (AreAnyPlantsAlive(plantLives))
            {
                for (int cnt = 0; cnt < plantLives.Length; cnt++)
                {
                    if (plantLives[cnt] != 0)
                    {
                        if ((daysCount % daysInSeason) != cnt)
                        {
                            plantLives[cnt]--;
                        }
                    }
                }

                daysCount++;
                if (daysCount % daysInSeason == 0)
                {
                    for (int cnt = 0; cnt < plantLives.Length; cnt++)
                    {
                        if (plantLives[cnt] != 0)
                        {
                            plantLives[cnt]++;
                        }
                    }
                }
            }
            int seasons = (daysCount - 1) / plantLives.Length;

            string seasonFormat = "seasons";
            if (seasons == 1)
            {
                seasonFormat = "season";
            }
            Console.WriteLine("survived {0} days ({1} {2})", daysCount, seasons, seasonFormat);
        }

        static bool AreAnyPlantsAlive(int[] plantLives)
        {
            for (int cnt = 0; cnt < plantLives.Length; cnt++)
            {
                if (plantLives[cnt] > 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
