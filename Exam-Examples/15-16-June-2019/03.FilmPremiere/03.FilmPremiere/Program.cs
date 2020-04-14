using System;

namespace _03.FilmPremiere
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            string food = Console.ReadLine();
            int ticketCount = int.Parse(Console.ReadLine());

            double sum = 0;

            switch (movie)
            {
                case "John Wick":
                    switch(food)
                    {
                        case "Drink":
                            sum = ticketCount * 12;
                            break;
                        case "Popcorn":
                            sum = ticketCount * 15;
                            break;
                        case "Menu":
                            sum = ticketCount * 19;
                            break;
                    }
                    break;
                case "Star Wars":
                    switch (food)
                    {
                        case "Drink":
                            sum = ticketCount * 18;
                            break;
                        case "Popcorn":
                            sum = ticketCount * 25;
                            break;
                        case "Menu":
                            sum = ticketCount * 30;
                            break;
                    }
                    if (ticketCount >= 4)
                    {
                        sum = sum - sum * 0.3;
                    }
                    break;
                case "Jumanji":
                    switch (food)
                    {
                        case "Drink":
                            sum = ticketCount * 9;
                            break;
                        case "Popcorn":
                            sum = ticketCount * 11;
                            break;
                        case "Menu":
                            sum = ticketCount * 14;
                            break;
                    }
                    if (ticketCount == 2)
                    {
                        sum = sum - sum * 0.15;
                    }
                    break;
            }
            Console.WriteLine($"Your bill is {sum:F2} leva.");
        }
    }
}
