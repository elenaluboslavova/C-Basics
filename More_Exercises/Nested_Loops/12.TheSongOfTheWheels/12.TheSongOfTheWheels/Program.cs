using System;

namespace _12.TheSongOfTheWheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int counter = 0;
            string pass = "";

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (a * b + c * d == M && a < b && c > d)
                            {
                                counter++;
                                Console.Write($"{a}{b}{c}{d} ");
                                if (counter == 4)
                                {
                                    pass = $"{a}{b}{c}{d}";
                                }
                            }
                        }
                    }
                }
            }
            if (counter >= 4)
            {
                Console.WriteLine();
                Console.WriteLine($"Password: {pass}");
            }
            if (counter < 4)
            {
                Console.WriteLine();
                Console.WriteLine("No!");
            }
        }
    }
}
