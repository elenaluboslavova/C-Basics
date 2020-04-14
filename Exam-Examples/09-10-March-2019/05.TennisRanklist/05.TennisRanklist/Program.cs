using System;

namespace _05.TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int firstPoints = int.Parse(Console.ReadLine());

            string stage = "";
            int points = 0;
            int pointsPerTournament = 0;
            int finalPoints = 0;
            int counter = 0;
            for (int i = 1; i <= tournaments; i++)
            {
                stage = Console.ReadLine();
                switch(stage)
                {
                    case "W":
                        points = 2000;
                        counter++;
                        break;
                    case "F":
                        points = 1200;
                        break;
                    case "SF":
                        points = 720;
                        break;
                }
                pointsPerTournament += points;
            }
            finalPoints = firstPoints + pointsPerTournament;
            Console.WriteLine($"Final points: {finalPoints}");
            Console.WriteLine($"Average points: {pointsPerTournament / tournaments}");
            Console.WriteLine($"{counter * 1.0 / tournaments * 100 :F2}%");
        }
    }
}
