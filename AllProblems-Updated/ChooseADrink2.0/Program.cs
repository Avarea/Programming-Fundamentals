using System;

namespace ChooseADrink2._0
{
    class Program
    {
        static void Main()
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("The {0} has to pay {1:f2}.", profession, quantity * GetADrink(profession));
        }

        private static double GetADrink(string profession)
        {
            double result;
            if (profession == "Athlete")
            {
                result = 0.7;
            }
            else if ((profession == "Businessman") || (profession == "Businesswoman"))
            {
                result = 1.00;
            }
            else if (profession == "SoftUni Student")
            {
                result = 1.7;
            }
            else
            {
                result = 1.2;
            }
            return result;
        }
    }
}
