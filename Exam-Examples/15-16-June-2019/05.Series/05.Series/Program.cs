using System;

namespace _05.Series
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            double finalPrice = 0;
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());

                switch(name)
                {
                    case "Thrones":
                        price = price * 0.5;
                        break;
                    case "Lucifer":
                        price = price * 0.6;
                        break;
                    case "Protector":
                        price = price * 0.7;
                        break;
                    case "TotalDrama":
                        price = price * 0.8;
                        break;
                    case "Area":
                        price = price * 0.9;
                        break;
                }
                finalPrice += price;
            }
            if (budget >= finalPrice)
            {
                Console.WriteLine($"You bought all the series and left with {budget-finalPrice:F2} lv.");
            }
            else
            {
                Console.WriteLine($"You need {finalPrice-budget:F2} lv. more to buy the series!");
            }
        }
    }
}
