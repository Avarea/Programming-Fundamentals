using System;

namespace _10DataOverflow
{
    class Program
    {
        static void Main()
        {
            ulong number1 = ulong.Parse(Console.ReadLine());
            ulong number2 = ulong.Parse(Console.ReadLine());

            decimal smaller = 0;
            decimal bigger = 0;

            string smallerType = string.Empty;
            string biggerType = string.Empty;

            if (number1 > number2)
            {
                smaller = number2;
                bigger = number1;
            }
            else
            {
                smaller = number1;
                bigger = number2;
            }

            decimal overflow = 0;

            if (smaller <= byte.MaxValue)
            {
                smallerType = "byte";
                overflow = bigger / byte.MaxValue;
            }
            else if (smaller <= ushort.MaxValue)
            {
                smallerType = "ushort";
                overflow = bigger / ushort.MaxValue;
            }
            else if (smaller <= uint.MaxValue)
            {
                smallerType = "uint";
                overflow = bigger / uint.MaxValue;
            }
            else
            {
                smallerType = "ulong";
                overflow = bigger / ulong.MaxValue;
            }

            if (bigger <= byte.MaxValue)
            {
                biggerType = "byte";
            }
            else if (bigger <= ushort.MaxValue)
            {
                biggerType = "ushort";
            }
            else if (bigger <= uint.MaxValue)
            {
                biggerType = "uint";
            }
            else
            {
                biggerType = "ulong";
            }

            Console.WriteLine("bigger type: {0}", biggerType);
            Console.WriteLine("smaller type: {0}", smallerType);
            Console.WriteLine("{0} can overflow {1} {2} times", bigger, smallerType, Math.Round(overflow));
        }
    }
}
