using System;

namespace _06.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double sum = 0;
            string place = "";
            string sleep = "";

            if (budget<=100)
            {
                switch (season)
                {
                    case "summer":
                        sum = budget * 3 / 10;
                        sleep = "Camp";
                        break;
                    case "winter":
                        sum = budget * 7 / 10;
                        sleep = "Hotel";
                        break;
                }
                place = "Bulgaria";
            }
            else if(budget>100 && budget<=1000)
            {
                switch (season)
                {
                    case "summer":
                        sum = budget * 4 / 10;
                        sleep = "Camp";
                        break;
                    case "winter":
                        sum = budget * 8 / 10;
                        sleep = "Hotel";
                        break;
                }
                place = "Balkans";
            }
            else if(budget>1000)
            {
                sum = budget * 9 / 10;
                place = "Europe";
                sleep = "Hotel";
            }

            Console.WriteLine($"Somewhere in {place}");
            Console.WriteLine($"{sleep} - {sum:F2}");
        }
    }
}
