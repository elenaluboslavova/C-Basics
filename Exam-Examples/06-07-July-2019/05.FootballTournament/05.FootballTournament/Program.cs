using System;

namespace _05.FootballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            int games = int.Parse(Console.ReadLine());

            char result = ' ';
            int points = 0;
            int countD = 0;
            int countW = 0;
            int countL = 0;

            if (games == 0)
            {
                Console.WriteLine($"{team} hasn't played any games during this season.");
                return;
            }

            for (int i = 1; i <= games; i++)
            {
                result = char.Parse(Console.ReadLine());

                switch(result)
                {
                    case 'W':
                        points += 3;
                        countW++;
                        break;
                    case 'D':
                        points += 1;
                        countD++;
                        break;
                    case 'L':
                        countL++;
                        break;
                }
            }

            Console.WriteLine($"{team} has won {points} points during this season.");
            Console.WriteLine("Total stats:");
            Console.WriteLine($"## W: {countW}");
            Console.WriteLine($"## D: {countD}");
            Console.WriteLine($"## L: {countL}");
            Console.WriteLine($"Win rate: {countW * 1.0 / games * 100 :F2}%");
        }
    }
}
