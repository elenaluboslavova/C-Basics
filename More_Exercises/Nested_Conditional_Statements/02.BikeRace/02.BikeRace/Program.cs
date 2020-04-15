using System;

namespace _02.BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniorsCount = int.Parse(Console.ReadLine());
            int seniorsCount = int.Parse(Console.ReadLine());
            string track = Console.ReadLine();

            double juniorFee = 0;
            double seniorFee = 0;

            if (track == "trail")
            {
                juniorFee = 5.50;
                seniorFee = 7;
            }
            else if (track == "cross-country")
            {
                juniorFee = 8;
                seniorFee = 9.50;
                if ((juniorsCount + seniorsCount) >= 50)
                {
                    juniorFee = 6;
                    seniorFee = 7.125;
                }
            }
            else if (track == "downhill")
            {
                juniorFee = 12.25;
                seniorFee = 13.75;
            }
            else if (track == "road")
            {
                juniorFee = 20;
                seniorFee = 21.50;
            }
            double finalSum = juniorsCount * juniorFee + seniorsCount * seniorFee;
            finalSum = finalSum - finalSum * 0.05;
            Console.WriteLine($"{finalSum:F2}");
        }
    }
}
