using System;

namespace _03.OscarsWeekInCinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            string hallType = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());

            double sum = 0;

            if (hallType == "normal")
            {
                switch(movie)
                {
                    case "A Star Is Born":
                        sum = tickets * 7.50;
                        break;
                    case "Bohemian Rhapsody":
                        sum = tickets * 7.35;
                        break;
                    case "Green Book":
                        sum = tickets * 8.15;
                        break;
                    case "The Favourite":
                        sum = tickets * 8.75;
                        break;
                }
            }

            else if (hallType == "luxury")
            {
                switch (movie)
                {
                    case "A Star Is Born":
                        sum = tickets * 10.50;
                        break;
                    case "Bohemian Rhapsody":
                        sum = tickets * 9.45;
                        break;
                    case "Green Book":
                        sum = tickets * 10.25;
                        break;
                    case "The Favourite":
                        sum = tickets * 11.55;
                        break;
                }
            }

            else if (hallType == "ultra luxury")
            {
                switch (movie)
                {
                    case "A Star Is Born":
                        sum = tickets * 13.50;
                        break;
                    case "Bohemian Rhapsody":
                        sum = tickets * 12.75;
                        break;
                    case "Green Book":
                        sum = tickets * 13.25;
                        break;
                    case "The Favourite":
                        sum = tickets * 13.95;
                        break;
                }
            }

            Console.WriteLine($"{movie} -> {sum:F2} lv.");
        }
    }
}
