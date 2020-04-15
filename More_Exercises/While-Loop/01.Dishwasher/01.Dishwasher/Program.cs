using System;

namespace _01.Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int bottles = int.Parse(Console.ReadLine());
            int availableDetergent = bottles * 750;
            string command = "";
            int dishesCount = 0;
            int potsCount = 0;
            int finalDishesCount = 0;
            int finalPotsCount = 0;
            int count = 0;
            int dishesDetergent = 0;
            int potsDetergent = 0;
            int counter = 0;

            while (availableDetergent >= 0)
            {
                counter++;
                command = Console.ReadLine();
                if (command == "End")
                {
                    Console.WriteLine("Detergent was enough!");
                    Console.WriteLine($"{finalDishesCount} dishes and {finalPotsCount} pots were washed.");
                    Console.WriteLine($"Leftover detergent {availableDetergent} ml.");
                    Environment.Exit(0);
                }
                if (counter%3==0)
                {
                    potsCount = int.Parse(command);
                    potsDetergent = potsCount * 15;
                    count += potsCount;
                    finalPotsCount += potsCount;
                    availableDetergent -= potsDetergent;
                }
                else
                {
                    dishesCount = int.Parse(command);
                    dishesDetergent = dishesCount * 5;
                    count += dishesCount;
                    finalDishesCount += dishesCount;
                    availableDetergent -= dishesDetergent;
                }
            }
            if (availableDetergent < 0)
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(availableDetergent)}" +
                    $" ml. more necessary!");
            }
        }
    }
}
