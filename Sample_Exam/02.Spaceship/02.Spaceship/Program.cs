using System;

namespace _02.Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double shipWidth = double.Parse(Console.ReadLine());
            double shipLength = double.Parse(Console.ReadLine());
            double shipHeight = double.Parse(Console.ReadLine());
            double peopleHeight = double.Parse(Console.ReadLine());

            double room = 2 * 2 * (peopleHeight + 0.40);
            double ship = shipHeight * shipLength * shipWidth;
            double people = Math.Floor(ship / room);

            if (people >= 3 && people <= 10)
            {
                Console.WriteLine($"The spacecraft holds {people} astronauts.");
            }
            else if (people < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        }
    }
}
