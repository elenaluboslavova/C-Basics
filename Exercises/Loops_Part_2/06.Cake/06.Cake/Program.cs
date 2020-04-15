using System;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int cake = width * length;
            string command = "";
            int pieceOfCake = 0;
            int piecesCount = 0;

            while (piecesCount < cake)
            {
                command = Console.ReadLine();
                if (command=="STOP")
                {
                    Console.WriteLine($"{cake-piecesCount} pieces are left.");
                    break;
                }
                pieceOfCake = int.Parse(command);
                piecesCount += pieceOfCake;
                
            }
            if (piecesCount >= cake)
            {
                Console.WriteLine($"No more cake left! You need {piecesCount - cake} pieces more.");
            }

        }
    }
}
