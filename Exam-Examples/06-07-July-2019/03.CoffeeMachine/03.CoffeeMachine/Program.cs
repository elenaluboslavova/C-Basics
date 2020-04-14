using System;

namespace _03.CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int countDrinks = int.Parse(Console.ReadLine());

            double sum = 0;

            if (drink == "Espresso")
            {
                switch(sugar)
                {
                    case "Without":
                        sum = countDrinks * 0.90;
                        break;
                    case "Normal":
                        sum = countDrinks;
                        break;
                    case "Extra":
                        sum = countDrinks * 1.20;
                        break;
                }
            }

            else if (drink == "Cappuccino")
            {
                switch (sugar)
                {
                    case "Without":
                        sum = countDrinks;
                        break;
                    case "Normal":
                        sum = countDrinks * 1.20;
                        break;
                    case "Extra":
                        sum = countDrinks * 1.60;
                        break;
                }
            }

            else if (drink == "Tea")
            {
                switch (sugar)
                {
                    case "Without":
                        sum = countDrinks * 0.50;
                        break;
                    case "Normal":
                        sum = countDrinks * 0.60;
                        break;
                    case "Extra":
                        sum = countDrinks * 0.70;
                        break;
                }
            }

            if (sugar == "Without")
            {
                sum = sum * 0.65;
            }

            if (drink == "Espresso" && countDrinks >= 5)
            {
                sum = sum * 0.75;
            }

            if (sum > 15)
            {
                sum = sum * 0.80;
            }

            Console.WriteLine($"You bought {countDrinks} cups of {drink} for {sum:F2} lv.");
        }
    }
}
