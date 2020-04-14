using System;

namespace _06.TripExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            double price = 0;
            double dailyMoney = 60;
            double moneyLeftSum = 0;
            double moneyLeft = 0;

            double priceSum = 0;
            int counter = 0;

            for (int i = 0; i < days; i++)
            {
                string command = Console.ReadLine();
                
                while (command != "Day over")
                {
                    price = double.Parse(command);
                    if (price > moneyLeft + dailyMoney)
                    {
                        continue;
                    }
                    counter++;
                    priceSum += price;

                    if (priceSum >= dailyMoney + moneyLeft)
                    {
                        Console.WriteLine($"Daily limit exceeded! You've bought {counter} products.");
                        break;
                    }

                    command = Console.ReadLine();
                }
                
                if (priceSum < dailyMoney + moneyLeft)
                {
                    moneyLeft = dailyMoney + moneyLeft - priceSum;
                    moneyLeftSum += moneyLeft;
                    Console.WriteLine($"Money left from today: {moneyLeftSum:F2}. You've bought {counter} products.");
                }

                price = 0;
                priceSum = 0;
                counter = 0;
                moneyLeftSum = 0;
            }
        }
    }
}
