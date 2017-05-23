using System;

namespace _05CharacterStats
{
	class Program
	{
		static void Main()
		{
			string charName = Console.ReadLine();
			int currentHealth = int.Parse(Console.ReadLine());
			int maxHealth = int.Parse(Console.ReadLine());
			int currentEnergy = int.Parse(Console.ReadLine());
			int maxEnergy = int.Parse(Console.ReadLine());

			int health = maxHealth - currentHealth;
			int energy = maxEnergy - currentEnergy;


			Console.WriteLine($"Name: {charName}");
			Console.WriteLine("Health: |{0}{1}|", new string('|', currentHealth), new string('.', health));
			Console.WriteLine("Energy: |{0}{1}|", new string('|', currentEnergy), new string('.', energy));
		}
	}
}
