using System;

namespace _04.CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string clas = "";
            string car = "";
            double sum = 0;

            if (budget <= 100)
            {
                clas = "Economy class";
                if (season == "Summer")
                {
                    car = "Cabrio";
                    sum = budget * 0.35;
                }
                else if (season == "Winter")
                {
                    car = "Jeep";
                    sum = budget * 0.65;
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                clas = "Compact class";
                if (season == "Summer")
                {
                    car = "Cabrio";
                    sum = budget * 0.45;
                }
                else if (season == "Winter")
                {
                    car = "Jeep";
                    sum = budget * 0.80;
                }
            }
            else if (budget > 500)
            {
                clas = "Luxury class";
                car = "Jeep";
                sum = budget * 0.9;
            }

            Console.WriteLine(clas);
            Console.WriteLine($"{car} - {sum:F2}");
        }
    }
}
