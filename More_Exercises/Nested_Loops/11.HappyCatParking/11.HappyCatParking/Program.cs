using System;

namespace _11.HappyCatParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double pricePerHour = 0;
            double sum = 0;
            double totalSum = 0;

            for (int i = 1; i <= days; i++)
            {
                sum = 0;
                for (int j = 1; j <= hours; j++)
                {
                    if (i % 2 == 0 && j % 2 == 1)
                    {
                        pricePerHour = 2.50;
                    }
                    else if (i % 2 == 1 && j % 2 == 0)
                    {
                        pricePerHour = 1.25;
                    }
                    else
                    {
                        pricePerHour = 1;
                    }
                    sum += pricePerHour;
                }
                totalSum += sum;
                Console.WriteLine($"Day: {i} - {sum:F2} leva");
                
            }
            Console.WriteLine($"Total: {totalSum:F2} leva");
        }
    }
}
