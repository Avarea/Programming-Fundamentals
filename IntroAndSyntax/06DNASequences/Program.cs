using System;

namespace _06DNASequences
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int count = 0;




            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    for (int k = 1; k <= 4; k++)
                    {
                        count++;
                        if ((i + j + k) >= input)
                        {
                            Console.Write("O" + ("" + i + j + k).Replace('1', 'A').Replace('2', 'C').Replace('3', 'G').Replace('4', 'T') + "O ");
                        }
                        else
                        {
                            Console.Write("X" + ("" + i + j + k).Replace('1', 'A').Replace('2', 'C').Replace('3', 'G').Replace('4', 'T') + "X ");
                        }
                        if (count % 4 == 0)
                        {
                            Console.WriteLine();
                        }

                    }
                }
            }

        }
    }
}
