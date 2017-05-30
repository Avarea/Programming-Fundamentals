using System;

namespace _02ChooseADrink2._0
{
    class Program
    {
        static void Main()
        {
            string proffession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0;

            if (proffession == "Athlete")
            {
                price = 0.7;
            }
            else if (proffession == "Businessman" || proffession == "Businesswoman")
            {
                price = 1.00;
            }
            else if (proffession == "SoftUni Student")
            {
                price = 1.7;
            }
            else
            {
                price = 1.2;
            }
            Console.WriteLine("The {0} has to pay {1:f2}.", proffession, (price * quantity));
        }
    }
}
