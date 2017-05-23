using System;


namespace _04BeverageLabels
{
    class Program
    {
        static void Main()
        {
            string beverage = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContent = int.Parse(Console.ReadLine());
            int sugarContent = int.Parse(Console.ReadLine());

            double energy = (volume * energyContent)/100;
            double sugar = (volume * (double)sugarContent)/100;

            Console.WriteLine($"{volume}ml {beverage}:");
            Console.WriteLine($"{energy}kcal, {sugar}g sugars");
        }
    }
}
