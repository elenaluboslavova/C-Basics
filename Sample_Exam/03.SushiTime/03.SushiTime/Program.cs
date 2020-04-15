using System;

namespace _03.SushiTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string sushi = Console.ReadLine();
            string restaurant = Console.ReadLine();
            int portions = int.Parse(Console.ReadLine());
            char delivery = char.Parse(Console.ReadLine());

            double sum = 0;

            if (restaurant == "Sushi Zone")
            {
                switch(sushi)
                {
                    case "sashimi":
                        sum = portions * 4.99;
                        break;
                    case "maki":
                        sum = portions * 5.29;
                        break;
                    case "uramaki":
                        sum = portions * 5.99;
                        break;
                    case "temaki":
                        sum = portions * 4.29;
                        break;
                }
            }

            else if (restaurant == "Sushi Time")
            {
                switch (sushi)
                {
                    case "sashimi":
                        sum = portions * 5.49;
                        break;
                    case "maki":
                        sum = portions * 4.69;
                        break;
                    case "uramaki":
                        sum = portions * 4.49;
                        break;
                    case "temaki":
                        sum = portions * 5.19;
                        break;
                }
            }

            else if (restaurant == "Sushi Bar")
            {
                switch (sushi)
                {
                    case "sashimi":
                        sum = portions * 5.25;
                        break;
                    case "maki":
                        sum = portions * 5.55;
                        break;
                    case "uramaki":
                        sum = portions * 6.25;
                        break;
                    case "temaki":
                        sum = portions * 4.75;
                        break;
                }
            }

            else if (restaurant == "Asian Pub")
            {
                switch (sushi)
                {
                    case "sashimi":
                        sum = portions * 4.50;
                        break;
                    case "maki":
                        sum = portions * 4.80;
                        break;
                    case "uramaki":
                        sum = portions * 5.50;
                        break;
                    case "temaki":
                        sum = portions * 5.50;
                        break;
                }
            }
            
            else
            {
                Console.WriteLine($"{restaurant} is invalid restaurant!");
                return;
            }

            if (delivery == 'Y')
            {
                sum = sum + sum * 0.2;
            }

            Console.WriteLine($"Total price: {Math.Ceiling(sum)} lv.");
        }
    }
}
