using System;

namespace _06.EasterDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int clients = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            int counter = 0;
            double sum = 0;
            double finalSum = 0;

            for (int i = 0; i < clients; i++)
            {
                sum = 0;
                counter = 0;
                while (command != "Finish")
                {
                    if (command == "basket")
                    {
                        sum += 1.50;
                        counter++;
                    }
                    else if (command == "wreath")
                    {
                        sum += 3.80;
                        counter++;
                    }
                    else if (command == "chocolate bunny")
                    {
                        sum += 7;
                        counter++;

                    }
                    command = Console.ReadLine();
                }
                if (counter % 2 == 0)
                {
                    sum = sum - 0.2 * sum;
                }
                finalSum += sum;
                Console.WriteLine($"You purchased {counter} items for {sum:F2} leva.");
                command = Console.ReadLine();
            }
            Console.WriteLine($"Average bill per client is: {finalSum / clients:F2} leva.");

        }
    }
}
