using System;

namespace _15NeighbourWars
{
    class Program
    {
        static void Main()
        {
            int peshoDmg = int.Parse(Console.ReadLine());
            int goshoDmg = int.Parse(Console.ReadLine());

            int peshoHealth = 100;
            int goshoHealth = 100;

            int turn = 0;

            for (int i = 1; i < int.MaxValue; i++)   
            {
                Console.ReadKey();


                if (i % 2 == 1)
                {
                    goshoHealth = goshoHealth - peshoDmg;
                    if (goshoHealth <= 0)
                    {
                        Console.WriteLine("Pesho won in {0}th round.", i);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", goshoHealth);
                    }
                    
                }
                
                else if (i % 2 == 0)
                {
                    peshoHealth = peshoHealth - goshoDmg;
                    if (peshoHealth <= 0)
                    {
                        Console.WriteLine("Gosho won in {0}th round.", i);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", peshoHealth);
                    }
                    
                }
                if (i % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
            }

        }
    }
}
