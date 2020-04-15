using System;

namespace _05.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string place = "";
            string city = "";
            double sum = 0;

            if (budget <= 1000)
            {
                place = "Camp";
                if (season == "Summer")
                {
                    city = "Alaska";
                    sum = budget * 0.65;
                }
                else if (season == "Winter")
                {
                    city = "Morocco";
                    sum = budget * 0.45;
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                place = "Hut";
                if (season == "Summer")
                {
                    city = "Alaska";
                    sum = budget * 0.80;
                }
                else if (season == "Winter")
                {
                    city = "Morocco";
                    sum = budget * 0.60;
                }
            }
            else if (budget > 3000)
            {
                place = "Hotel";
                if (season == "Summer")
                {
                    city = "Alaska";
                }
                else if (season == "Winter")
                {
                    city = "Morocco";
                }
                sum = budget * 0.9;
            }

            Console.WriteLine($"{city} - {place} - {sum:F2}");
        }
    }
}
