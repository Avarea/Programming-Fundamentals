using System;

namespace _08SMSTyping
{
    class Program
    {
        static void Main()
        {
            int charNum = int.Parse(Console.ReadLine());
            string word = string.Empty;

            for (int i = 1; i <= charNum; i++)
            {
                int integers = int.Parse(Console.ReadLine());


                if (integers == 0)
                {
                    word += " ";
                }
                else
                {
                    int digitLenght = integers.ToString().Length;
                    int mainDigit = 0;
                    if (integers < 10)
                    {
                        mainDigit = integers;
                    }
                    else
                    {
                        while (integers >= 10)
                        {
                            integers /= 10;
                            mainDigit = integers;
                        }
                    }


                    int offsetNumber = (mainDigit - 2) * 3;

                    if (mainDigit == 8 || mainDigit == 9)
                    {
                        offsetNumber++;
                    }

                    int letterIndex = (offsetNumber + digitLenght - 1);
                    word += (char)(letterIndex + 97);
                }

            }
            Console.WriteLine(word);
        }
    }
}
