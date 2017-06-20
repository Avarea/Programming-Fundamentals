using System;

namespace ChooseADrink
{
    class Program
    {
        static void Main()
        {
            string profession = Console.ReadLine();
            Console.WriteLine(GetADrink(profession));
        }

        private static string GetADrink(string profession)
        {
            string result = string.Empty;
            if (profession == "Athlete")
            {
                result = "Water";
            }
            else if ((profession == "Businessman") || (profession == "Businesswoman"))
            {
                result = "Coffee";
            }
            else if (profession == "SoftUni Student")
            {
                result = "Beer";
            }
            else
            {
                result = "Tea";
            }
            return result;
        }
    }
}
