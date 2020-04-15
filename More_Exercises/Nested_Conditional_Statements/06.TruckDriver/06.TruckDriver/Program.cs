using System;

namespace _06.TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmPerMonth = double.Parse(Console.ReadLine());

            double sum = 0;

            if (season == "Spring" || season == "Autumn")
            {
                if (kmPerMonth <= 5000)
                {
                    sum = kmPerMonth * 0.75;
                }
                else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                {
                    sum = kmPerMonth * 0.95;
                }
                else if (kmPerMonth > 10000 && kmPerMonth <= 20000)
                {
                    sum = kmPerMonth * 1.45;
                }
            }


            else if (season == "Summer")
            {
                if (kmPerMonth <= 5000)
                {
                    sum = kmPerMonth * 0.90;
                }
                else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                {
                    sum = kmPerMonth * 1.10;
                }
                else if (kmPerMonth > 10000 && kmPerMonth <= 20000)
                {
                    sum = kmPerMonth * 1.45;
                }
            }


            else if (season == "Winter")
            {
                if (kmPerMonth <= 5000)
                {
                    sum = kmPerMonth * 1.05;
                }
                else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                {
                    sum = kmPerMonth * 1.25;
                }
                else if (kmPerMonth > 10000 && kmPerMonth <= 20000)
                {
                    sum = kmPerMonth * 1.45;
                }
            }

            sum = sum - sum * 0.1;
            Console.WriteLine($"{sum*4:F2}");
        }
    }
}
