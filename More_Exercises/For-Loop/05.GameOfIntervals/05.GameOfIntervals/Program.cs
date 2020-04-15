using System;

namespace _05.GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double number = 0;
            double result = 0;
            double pr1 = 0;
            double pr2 = 0;
            double pr3 = 0;
            double pr4 = 0;
            double pr5 = 0;
            double pr6 = 0;

            for (int i = 0; i < n; i++)
            {
                number = double.Parse(Console.ReadLine());

                if (number >= 0 && number <= 9)
                {
                    result += number * 0.2;
                    pr1++;
                }
                else if (number >= 10 && number <= 19)
                {
                    result += number * 0.3;
                    pr2++;
                }
                else if (number >= 20 && number <= 29)
                {
                    result += number * 0.4;
                    pr3++;
                }
                else if (number >= 30 && number <= 39)
                {
                    result += 50;
                    pr4++;
                }
                else if (number >= 40 && number <= 50)
                {
                    result += 100;
                    pr5++;
                }
                else
                {
                    result = result / 2;
                    pr6++;
                }
            }
            Console.WriteLine($"{result:F2}");
            Console.WriteLine($"From 0 to 9: {pr1 / n * 100 :F2}%");
            Console.WriteLine($"From 10 to 19: {pr2 / n * 100:F2}%");
            Console.WriteLine($"From 20 to 29: {pr3 / n * 100:F2}%");
            Console.WriteLine($"From 30 to 39: {pr4 / n * 100:F2}%");
            Console.WriteLine($"From 40 to 50: {pr5 / n * 100:F2}%");
            Console.WriteLine($"Invalid numbers: {pr6 / n * 100:F2}%");
        }
    }
}
