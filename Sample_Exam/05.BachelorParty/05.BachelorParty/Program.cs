using System;

namespace _05.BachelorParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int moneyForGuest = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            int people = 0;
            int sum = 0;
            int finalSum = 0;
            int finalPeople = 0;

            while (command != "The restaurant is full")
            {
                people = int.Parse(command);
                finalPeople += people;
                if (people < 5)
                {
                    sum = 100 * people;
                }
                else
                {
                    sum = 70 * people;
                }
                finalSum += sum;
                command = Console.ReadLine();
            }
            if (finalSum >= moneyForGuest)
            {
                Console.WriteLine($"You have {finalPeople} guests and {finalSum - moneyForGuest} leva left.");
                
            }
            else
            {
                Console.WriteLine($"You have {finalPeople} guests and {finalSum} leva income, but no singer.");

            }
        }
    }
}
