using System;

namespace _10.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int freeSpaceWidth = int.Parse(Console.ReadLine());
            int freeSpaceLength = int.Parse(Console.ReadLine());
            int freeSpaceHeigth = int.Parse(Console.ReadLine());

            int roomSpace = freeSpaceHeigth * freeSpaceLength * freeSpaceWidth;
            string command = Console.ReadLine();

            while (command != "Done")
            {
                int boxesCount = int.Parse(command);
                roomSpace -= boxesCount;
                
                if (roomSpace <= 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(roomSpace)}" +
                        $" Cubic meters more.");
                    break;
                }
                command = Console.ReadLine();
            }
            if (roomSpace > 0)
            {
                Console.WriteLine($"{roomSpace} Cubic meters left.");
            }
        }
    }
}
