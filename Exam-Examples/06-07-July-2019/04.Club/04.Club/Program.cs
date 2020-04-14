using System;

namespace _04.Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double wantedIncome = double.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            int count = 0;
            double price = 0;
            double finalPrice = 0;

            while (input != "Party!")
            {
                if (finalPrice >= wantedIncome)
                {
                    Console.WriteLine($"Target acquired.");
                    Console.WriteLine($"Club income - {finalPrice:F2} leva.");

                    return;
                }
                count = int.Parse(Console.ReadLine());
                price = input.Length * count;
                if (price % 2 == 1)
                {
                    price = input.Length * count * 0.75;
                }
                finalPrice += price;



                input = Console.ReadLine();
            }
            if (finalPrice >= wantedIncome)
            {
                Console.WriteLine($"Target acquired.");
            }
            else
            {
                Console.WriteLine($"We need {wantedIncome-finalPrice:F2} leva more.");
            }
            Console.WriteLine($"Club income - {finalPrice:F2} leva.");
        }
    }
}
