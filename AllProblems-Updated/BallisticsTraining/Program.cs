using System;
using System.Linq;

namespace BallisticsTraining
{
    class Program
    {
        static void Main()
        {
            int[] coordinates = Console.ReadLine()?.Split(' ').Select(int.Parse).ToArray();
            string[] commands = Console.ReadLine()?.Split(' ').ToArray();

            int currentPositionX = coordinates[0];
            int currentPositionY = coordinates[1];
            int startX = 0;
            int startY = 0;

            for (int cntIndex = 0; cntIndex < commands.Length - 1; cntIndex+=2)
            {
                switch (commands[cntIndex])
                {
                    case "up":
                        startY += int.Parse(commands[cntIndex + 1]);
                        break;
                    case "down":
                        startY -= int.Parse(commands[cntIndex + 1]);
                        break;
                    case "left":
                        startX -= int.Parse(commands[cntIndex + 1]);
                        break;
                    case "right":
                        startX += int.Parse(commands[cntIndex + 1]);
                        break;
                }
            }
            Console.WriteLine($"firing at [{startX}, {startY}]");
            if (currentPositionX == startX && currentPositionY == startY)
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }
        }
    }
}
