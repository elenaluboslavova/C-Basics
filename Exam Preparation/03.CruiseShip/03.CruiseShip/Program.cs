using System;

namespace _03.CruiseShip
{
    class Program
    {
        static void Main(string[] args)
        {
            string cruiseType = Console.ReadLine();
            string roomType = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double sum = 0;

            if (cruiseType == "Mediterranean")
            {
                switch(roomType)
                {
                    case "standard cabin":
                        sum = 4 * nights * 27.50;
                        break;
                    case "cabin with balcony":
                        sum = 4 * nights * 30.20;
                        break;
                    case "apartment":
                        sum = 4 * nights * 40.50;
                        break;
                }
            }

            else if (cruiseType == "Adriatic")
            {
                switch (roomType)
                {
                    case "standard cabin":
                        sum = 4 * nights * 22.99;
                        break;
                    case "cabin with balcony":
                        sum = 4 * nights * 25.00;
                        break;
                    case "apartment":
                        sum = 4 * nights * 34.99;
                        break;
                }
            }

            else if (cruiseType == "Aegean")
            {
                switch (roomType)
                {
                    case "standard cabin":
                        sum = 4 * nights * 23.00;
                        break;
                    case "cabin with balcony":
                        sum = 4 * nights * 26.60;
                        break;
                    case "apartment":
                        sum = 4 * nights * 39.80;
                        break;
                }
            }
            if (nights > 7)
            {
                sum = sum * 0.75;
            }
            Console.WriteLine($"Annie's holiday in the {cruiseType} sea costs {sum:F2} lv.");
        }
    }
}
