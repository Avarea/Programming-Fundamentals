using System;

namespace CharacterStats
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            GetStats(currentHealth, maxHealth, currentEnergy, maxEnergy);
        }

        private static void GetStats(int currentHealth, int maxHealth, int currentEnergy, int maxEnergy)
        {
            Console.WriteLine("Health: |{0}{1}|", new string('|', currentHealth), new string('.', maxHealth - currentHealth));
            Console.WriteLine("Energy: |{0}{1}|", new string('|', currentEnergy), new string('.', maxEnergy - currentEnergy));
        }
    }
}
