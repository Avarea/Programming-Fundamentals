using System;
//Problem 1 – Sweet Dessert - Exam Preparation IV
namespace _01SweetDesert
{
    class Program
    {
        static void Main()
        {
            double availableCash = double.Parse(Console.ReadLine());
            int guest = int.Parse(Console.ReadLine());
            double bannanaPrice = double.Parse(Console.ReadLine());
            double eggsPrice = double.Parse(Console.ReadLine());
            double berriesPrice = double.Parse(Console.ReadLine());

            double portionsNeeded = Math.Ceiling((double)guest / 6);
            double moneyNeeded = (portionsNeeded * 2 * bannanaPrice) + (4 * eggsPrice * portionsNeeded) + (0.2 * berriesPrice * portionsNeeded);

            if (moneyNeeded > availableCash)
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", Math.Abs(moneyNeeded - availableCash));
            }
            else
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", moneyNeeded);
            }

        }
    }
}
