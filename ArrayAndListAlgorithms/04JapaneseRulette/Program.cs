using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04JapaneseRulette
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bullets = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int indexBullet = 0;
            string[] players = 
            bool isDead = false;

            for (int i = 0; i < players.Lenght; i++)
            {
                string[] token = players[i].Split(',');
                string direction = token[1];
                int power = int.Parse(token[0]);

                switch (direction)
                {
                    case "Right":
                        indexBullet = (indexBullet + power) % bullets.Length;
                        break;
                    case "Left":
                        if (indexBullet - power < 0)
                        {
                            indexBullet = bullets.Length - (Math.Abs(indexBullet - power) % bullets.Length);
                        }
                        else
                        {
                            
                        }
                        break;
                }

                if (indexBullet == 2)
                {
                    Console.WriteLine($"Game over! Player {i} is dead!");
                    isDead = true;
                    break;
                }
                indexBullet = indexBullet + 1 == bullets.Length ? 0 : power + 1;
            }
        }
    }
}
