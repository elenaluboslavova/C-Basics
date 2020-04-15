using System;

namespace _08.FuelTank_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double fuel = double.Parse(Console.ReadLine());
            string card = Console.ReadLine();

            if (fuelType=="Gas")
            {
                double sum = fuel * 0.93;
                if (card=="Yes")
                {
                    sum = sum - fuel * 0.08;
                }
                if (fuel>=20 && fuel<=25)
                {
                    sum = sum - sum * 8 / 100;
                }
                else if (fuel>25)
                {
                    sum = sum - sum * 10 / 100;
                }
                Console.WriteLine($"{sum:F2} lv.");
            }
            else if (fuelType=="Gasoline")
            {
                double sum = fuel * 2.22;
                if (card == "Yes")
                {
                    sum = sum - fuel * 0.18;
                }
                if (fuel >= 20 && fuel <= 25)
                {
                    sum = sum - sum * 8 / 100;
                }
                else if (fuel > 25)
                {
                    sum = sum - sum * 10 / 100;
                }
                Console.WriteLine($"{sum:F2} lv.");
            }
            else if (fuelType=="Diesel")
            {
                double sum = fuel * 2.33;
                if (card == "Yes")
                {
                    sum = sum - fuel * 0.12;
                }
                if (fuel >= 20 && fuel <= 25)
                {
                    sum = sum - sum * 8 / 100;
                }
                else if (fuel > 25)
                {
                    sum = sum - sum * 10 / 100;
                }
                Console.WriteLine($"{sum:F2} lv.");
            }
        }
    }
}
