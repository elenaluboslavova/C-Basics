using System;

namespace _05.EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int paintedEggs = int.Parse(Console.ReadLine());

            string color = "";
            int redCounter = 0;
            int orangeCounter = 0;
            int blueCounter = 0;
            int greenCounter = 0;

            int max = int.MinValue;

            string maxColor = "";

            for (int i = 0; i < paintedEggs; i++)
            {
                color = Console.ReadLine();

                if (color == "red")
                {
                    redCounter++;
                    if (redCounter > max)
                    {
                        max = redCounter;
                        maxColor = "red";
                    }
                }
                else if (color == "orange")
                {
                    orangeCounter++;
                    if (orangeCounter > max)
                    {
                        max = orangeCounter;
                        maxColor = "orange";
                    }
                }
                else if (color == "blue")
                {
                    blueCounter++;
                    if (blueCounter > max)
                    {
                        max = blueCounter;
                        maxColor = "blue";
                    }
                }
                else if (color == "green")
                {
                    greenCounter++;
                    if (greenCounter > max)
                    {
                        max = greenCounter;
                        maxColor = "green";
                    }
                }
            }

            Console.WriteLine($"Red eggs: {redCounter}");
            Console.WriteLine($"Orange eggs: {orangeCounter}");
            Console.WriteLine($"Blue eggs: {blueCounter}");
            Console.WriteLine($"Green eggs: {greenCounter}");
            Console.WriteLine($"Max eggs: {max} -> {maxColor}");
        }
    }
}
