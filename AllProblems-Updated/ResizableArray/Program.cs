using System;

namespace ResizableArray
{
    class Program
    {
        static int[] elements;
        static int elementsLenght;

        static void Main()
        {
            string[] inputTokens = Console.ReadLine().Split(' ');
            elements = new int[4];
            elementsLenght = 0;

            while (inputTokens[0] != "end")
            {
                string command = inputTokens[0];
                switch (command)
                {
                    case "push":
                        elements[elementsLenght] = int.Parse(inputTokens[1]);
                        elementsLenght++;

                        if (elementsLenght >= elements.Length)
                        {
                            GrowArray();
                        }
                        break;
                    case "pop":
                        elements[elementsLenght] = 0;
                        elementsLenght--;
                        break;
                    case "removeAt":
                        int index = int.Parse(inputTokens[1]);
                        ShiftArray(index);
                        elementsLenght--;
                        break;
                    case "clear":
                        elementsLenght = 0;
                        break;
                    default:
                        break;
                }
                inputTokens = Console.ReadLine().Split(' ');
            }
            PrintArray();
        }

        static void PrintArray()
        {
            for (int cnt = 0; cnt < elementsLenght; cnt++)
            {
                Console.Write(elements[cnt] + " ");
            }
            Console.WriteLine();
        }

        static void ShiftArray(int index)
        {
            for (int cnt = index + 1; cnt < elementsLenght; cnt++)
            {
                elements[cnt - 1] = elements[cnt];
            }
        }

        static void GrowArray()
        {
            int[] newArray = new int[elementsLenght * 2];

            for (int cnt = 0; cnt < elementsLenght; cnt++)
            {
                newArray[cnt] = elements[cnt];
            }
            elements = newArray;
        }
    }
}
