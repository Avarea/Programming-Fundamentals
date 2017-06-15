using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18BallisticsTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            var airplaneCoordinates = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var commands = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToList();


            int fireAtXCoordinates = 0;
            int fireAtYCoordinates = 0;

            for (int i = 0; i < commands.Count; i+= 2)
            {
                var command = commands[i];
                var coordinates = int.Parse(commands[i + 1]);

                switch (command)
                {
                    case "up":
                        fireAtYCoordinates += coordinates;
                        break;
                    case "down":
                        fireAtYCoordinates -= coordinates;
                        break;
                    case "left":
                        fireAtXCoordinates -= coordinates;
                        break;
                    case "right":
                        fireAtXCoordinates += coordinates;
                        break;
                }
            }
            var result = string.Empty;
            if (fireAtXCoordinates == airplaneCoordinates[0] && fireAtYCoordinates == airplaneCoordinates[1])
            {
                result = "got 'em!";
            }
            else
            {
                result = "better luck next time...";
            }
            Console.WriteLine("firing at [{0}, {1}]", fireAtXCoordinates, fireAtYCoordinates);
            Console.WriteLine(result);
        }
    }
}
