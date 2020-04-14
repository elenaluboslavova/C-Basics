using System;

namespace _04.GameNumberWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameFirst = Console.ReadLine();
            string nameSecond = Console.ReadLine();

            int cardFirst = 0;
            int cardSecond = 0;

            int pointsFirst = 0;
            int pointsSecond = 0;

            int finalFirst = 0;
            int finalSecond = 0;

            string command = Console.ReadLine();
            while (command != "End of game")
            {
                cardFirst = int.Parse(command);
                cardSecond = int.Parse(Console.ReadLine());

                if (cardFirst == cardSecond)
                {
                    cardFirst = int.Parse(Console.ReadLine());
                    cardSecond = int.Parse(Console.ReadLine());

                    Console.WriteLine("Number wars!");
                    if (cardFirst > cardSecond)
                    {
                        Console.WriteLine($"{nameFirst} is winner with {finalFirst} points");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"{nameSecond} is winner with {finalSecond} points");
                        return;
                    }

                    
                }
                if (cardFirst > cardSecond)
                {
                    pointsFirst = cardFirst - cardSecond;
                    finalFirst += pointsFirst;
                }
                else if (cardSecond > cardFirst)
                {
                    pointsSecond = cardSecond - cardFirst;
                    finalSecond += pointsSecond;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"{nameFirst} has {finalFirst} points");
            Console.WriteLine($"{nameSecond} has {finalSecond} points");
        }
    }
}
