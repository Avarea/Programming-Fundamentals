using System;

namespace _04PhotoGallery
{
    class Program
    {
        static void Main()
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            double size = double.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double result = (width * height / 1000000);
            double resolution = Math.Round(result, 1);

            string dataType = "B";
            if (size > 1000)
            {
                size = size / 1000;
                dataType = "KB";

                if (size >= 1000)
                {
                    size = size / 1000;
                    dataType = "MB";

                    if (size >= 1000)
                    {
                        size = size / 1000;
                        dataType = "GB";
                    }
                }
            }

            string orientation = string.Empty;
            if (width == height)
            {
                orientation = "square";
            }
            else if (width >= height)
            {
                orientation = "landscape";
            }
            else
            {
                orientation = "portrait";            }

            Console.WriteLine("Name: DSC_{0:d4}.jpg", photoNumber);
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year} {hours:d2}:{minutes:d2}");
            Console.WriteLine("Size: {0}{1}", size, dataType);
            Console.WriteLine("Resolution: {0}x{1} ({2})", width, height, orientation);
        }
    }
}
