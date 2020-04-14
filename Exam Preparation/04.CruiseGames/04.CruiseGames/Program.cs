using System;

namespace _04.CruiseGames
{
    class Program
    {
        static void Main(string[] args)
        {
            string player = Console.ReadLine();
            int games = int.Parse(Console.ReadLine());

            string game = "";
            double points = 0;
            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;

            double finalV = 0;
            double finalT = 0;
            double finalB = 0;

            for (int i = 0; i < games; i++)
            {
                game = Console.ReadLine();
                points = double.Parse(Console.ReadLine());
                switch (game)
                {
                    case "volleyball":
                        points = points + points * 0.07;
                        counter1++;
                        finalV += points;
                        break;
                    case "tennis":
                        points = points + points * 0.05;
                        counter2++;
                        finalT += points;
                        break;
                    case "badminton":
                        points = points + points * 0.02;
                        counter3++;
                        finalB += points;
                        break;
                }
                
            }
            if (Math.Floor(finalV/counter1) >= 75 && Math.Floor(finalT / counter2) >= 75 && Math.Floor(finalB / counter3) >= 75)
            {
                Console.WriteLine($"Congratulations, {player}! You won the cruise games with {Math.Floor(finalV+finalT+finalB)} points.");
            }
            else
            {
                Console.WriteLine($"Sorry, {player}, you lost. Your points are only {Math.Floor(finalV + finalT + finalB)}.");
            }
        }
    }
}
