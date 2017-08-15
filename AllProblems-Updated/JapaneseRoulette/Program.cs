using System;
using System.Linq;

namespace JapaneseRoulette
{
    class Program
    {
        static void Main()
        {
            int[] bullets = Console.ReadLine()?.Split(' ').Select(int.Parse).ToArray();
            string[] players = Console.ReadLine()?.Split(' ');
            bool isDead = false;

            int indexOfBullet = 0;
            for (int i = 0; i < bullets.Length; i++)
            {
                if (bullets[i] == 1)
                {
                    indexOfBullet = i;
                    break;
                }
            }

            for (int cnt = 0; cnt < players.Length; cnt++)
            {
                string[] tokens = players[cnt].Split(',');
                string direction = tokens[1];
                int power = int.Parse(tokens[0]);

                switch (direction)
                {
                    case "Right":
                        indexOfBullet = (indexOfBullet + power) % bullets.Length;
                        break;
                    case "Left":
                        if (indexOfBullet - power < 0)
                        {
                            indexOfBullet = bullets.Length - (Math.Abs(indexOfBullet - power) % bullets.Length);
                        }
                        else
                        {
                            indexOfBullet = indexOfBullet - power;
                        }
                        break;
                }
                if (indexOfBullet == 2)
                {
                    Console.WriteLine($"Game over! Player {cnt} is dead.");
                    isDead = true;
                    break;
                }
                indexOfBullet = indexOfBullet + 1 == bullets.Length ? 0 : indexOfBullet + 1;
            }
            if (!isDead)
            {
                Console.WriteLine($"Everybody got lucky!");
            }
        }
    }
}
