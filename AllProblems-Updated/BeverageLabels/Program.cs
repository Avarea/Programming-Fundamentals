using System;

namespace BeverageLabels
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energyContent = double.Parse(Console.ReadLine());
            double sugarContent = double.Parse(Console.ReadLine());

            GetLabel(name, volume, energyContent, sugarContent);
        }

        private static void GetLabel(string name, double volume, double energyContent, double sugarContent)
        {
            double energy = energyContent * volume / 100;
            double sugar = sugarContent * volume / 100;
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energy}kcal, {sugar}g sugars");
        }
    }
}
