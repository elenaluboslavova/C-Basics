using System;

namespace _06.BakingCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int cooks = int.Parse(Console.ReadLine());

            double sum = 0;
            double sumEnd = 0;
            int counterSweetsAll = 0;

            int counterCookies = 0;
            int counterCakes = 0;
            int counterWaffles = 0;

            for (int i = 1; i <= cooks; i++)
            {
                counterCookies = 0;
                counterCakes = 0;
                counterWaffles = 0;

                string name = Console.ReadLine();
                string command = Console.ReadLine();

                while (command != "Stop baking!")
                {
                    int countOfSweets = int.Parse(Console.ReadLine());
                    counterSweetsAll += countOfSweets;
                    switch (command)
                    {
                        case "cookies":
                            sum = countOfSweets * 1.50;
                            counterCookies += countOfSweets;
                            break;
                        case "cakes":
                            sum = countOfSweets * 7.80;
                            counterCakes += countOfSweets;
                            break;
                        case "waffles":
                            sum = countOfSweets * 2.30;
                            counterWaffles += countOfSweets;
                            break;
                    }
                    sumEnd += sum;
                    sum = 0;
                    
                    command = Console.ReadLine();
                }
                Console.WriteLine($"{name} baked {counterCookies} cookies, {counterCakes} cakes and {counterWaffles} waffles.");
            }
            Console.WriteLine($"All bakery sold: {counterSweetsAll}");
            Console.WriteLine($"Total sum for charity: {sumEnd:F2} lv.");
        }
    }
}
