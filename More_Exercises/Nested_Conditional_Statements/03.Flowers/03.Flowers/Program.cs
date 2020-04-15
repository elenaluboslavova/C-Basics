using System;

namespace _03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            double chrysanthemumsCount = double.Parse(Console.ReadLine());
            double rosesCount = double.Parse(Console.ReadLine());
            double tulipsCount = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            char holiday = char.Parse(Console.ReadLine());

            double flowers = chrysanthemumsCount + rosesCount + tulipsCount;
            double chrysanthemums = 0;
            double roses = 0;
            double tulips = 0;

            if (season == "Spring" || season == "Summer")
            {
                chrysanthemums = 2.00 * chrysanthemumsCount;
                roses = 4.10 * rosesCount;
                tulips = 2.50 * tulipsCount;
            }
            else if (season == "Autumn" || season == "Winter")
            {
                chrysanthemums = 3.75 * chrysanthemumsCount;
                roses = 4.50 * rosesCount;
                tulips = 4.15 * tulipsCount;
            }

            double sum = chrysanthemums + roses + tulips;
            if (holiday == 'Y')

            {
                sum = sum + sum * 0.15;
            }
            if (season == "Spring" && tulipsCount > 7)
            {
                sum = sum - sum * 0.05;
            }
            if (flowers > 20)
            {
                sum = sum - sum * 0.2;
            }
            if (season == "Winter" && rosesCount >= 10)
            {
                sum = sum - sum * 0.1;
            }

            Console.WriteLine($"{(sum+2):F2}");
        }
    }
}
