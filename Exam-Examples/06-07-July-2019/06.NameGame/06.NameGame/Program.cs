using System;

namespace _06.NameGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int number = 0;
            int points = 0;
            int max = int.MinValue;
            string winner = "";

            while (input != "Stop")
            {
                points = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    number = int.Parse(Console.ReadLine());

                    if (number == (int)input[i])
                    {
                        points += 10;
                    }
                    else
                    {
                        points += 2;
                    }

                }
                if (points > max)
                {
                    max = points;
                    winner = input;
                }



                input = Console.ReadLine();
            }
            Console.WriteLine($"The winner is {winner} with {max} points!");
        }
    }
}
