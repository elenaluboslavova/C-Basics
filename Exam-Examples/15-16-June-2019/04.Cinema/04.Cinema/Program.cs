using System;

namespace _04.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int people = 0;
            int sum = 0;
            int finalSum = 0;
            int finalPeople = 0;

            while (command != "Movie time!")
            {
                people = int.Parse(command);
                finalPeople += people;
                if (finalPeople > capacity)
                {
                    Console.WriteLine("The cinema is full.");
                    Console.WriteLine($"Cinema income - {finalSum} lv.");
                    return;
                }
                sum = people * 5;
                if (people % 3 == 0)
                {
                    sum -= 5;
                }
                finalSum += sum;


                command = Console.ReadLine();
            }
            Console.WriteLine($"There are {capacity-finalPeople} seats left in the cinema.");
            Console.WriteLine($"Cinema income - {finalSum} lv.");
        }
    }
}
