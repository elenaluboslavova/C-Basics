using System;

namespace _03.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int vineYardArea = int.Parse(Console.ReadLine());
            double grape = double.Parse(Console.ReadLine());
            int neededWine = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());


            double wineLiters = vineYardArea * grape * 40 / 100 / 2.5;
            if (wineLiters >= neededWine)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wineLiters)} liters.");
                Console.WriteLine($"{Math.Ceiling(wineLiters - neededWine)} liters left -> {Math.Ceiling(wineLiters - neededWine) / workersCount} liters per person.");
            }
            else if(wineLiters<neededWine)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(neededWine-wineLiters)} liters wine needed.");
            }
        }
    }
}
