using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01RabbitHole
{
    class Program
    {
        static void Main()
        {
            List<string> commands = Console.ReadLine().Split(' ').ToList();
            int initialEnergy = int.Parse(Console.ReadLine());

            int currentIndex = 0;

            while (initialEnergy > 0)
            {
                bool amIDeadFromTheBomb = false;
                string[] currentCommand = commands[currentIndex].Split('|');
                string action = currentCommand[0];

                if (action == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    break;
                }
                int energyValue = int.Parse(currentCommand[1]);

                switch (action)
                {
                    case "Left":
                        currentIndex = Math.Abs(currentIndex - energyValue) % commands.Count;
                        initialEnergy -= energyValue;
                        break;
                    case "Right":
                        currentIndex = Math.Abs(currentIndex + energyValue) % commands.Count;
                        initialEnergy -= energyValue;
                        break;
                    case "Bomb":
                        commands.RemoveAt(currentIndex);
                        currentIndex = 0;
                        initialEnergy -= energyValue;
                        amIDeadFromTheBomb = true;
                        break;
                }

                if (commands[commands.Count - 1] != "RabbitHole")
                {
                    commands.RemoveAt(commands.Count - 1);
                }
                commands.Add("Bomb|" + initialEnergy);

                if (initialEnergy <= 0 && amIDeadFromTheBomb)
                {
                    Console.WriteLine("You are dead due to bomb explosion!");//Yes you are!
                }
                else if (initialEnergy <= 0 && !amIDeadFromTheBomb)
                {
                    Console.WriteLine("You are tired. You can't continue the mission.");//noob
                }
            }
        }
    }
}
