using System;

namespace _03.EnergyBooster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string setSize = Console.ReadLine();
            int setCount = int.Parse(Console.ReadLine());

            double sum = 0;

            if (setSize == "small")
            {
                switch(fruit)
                {
                    case "Watermelon":
                        sum = 2 * 56 * setCount;
                        break;
                    case "Mango":
                        sum = 2 * 36.66 * setCount;
                        break;
                    case "Pineapple":
                        sum = 2 * 42.10 * setCount;
                        break;
                    case "Raspberry":
                        sum = 2 * 20 * setCount;
                        break;
                }
            }

            else if (setSize == "big")
            {
                switch (fruit)
                {
                    case "Watermelon":
                        sum = 5 * 28.70 * setCount;
                        break;
                    case "Mango":
                        sum = 5 * 19.60 * setCount;
                        break;
                    case "Pineapple":
                        sum = 5 * 24.80 * setCount;
                        break;
                    case "Raspberry":
                        sum = 5 * 15.20 * setCount;
                        break;
                }
            }

            if (sum >= 400 && sum <= 1000)
            {
                sum = sum - sum * 0.15;
            }
            else if (sum > 1000)
            {
                sum = sum * 0.5;
            }

            Console.WriteLine($"{sum:F2} lv.");
        }
    }
}
