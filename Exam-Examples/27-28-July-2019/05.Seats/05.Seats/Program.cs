using System;

namespace _05.Seats
{
    class Program
    {
        static void Main(string[] args)
        {
            int tickets = int.Parse(Console.ReadLine());

            string number = "";

            for (int i = 1; i <= tickets; i++)
            {
                number = Console.ReadLine();

                char first = number[0];
                char second = number[1];
                char third = number[2];
                char fourth = number[3];

                if (number.Length == 4)
                {
                    if (first >= 'A' && first <= 'Z')
                    {
                        Console.WriteLine($"Seat decoded: {first}{second}{third}");
                    }
                    else
                    {
                        Console.WriteLine($"Seat decoded: {fourth}{second}{third}");
                    }
                }

                else if (number.Length == 5 || number.Length == 6)
                {
                    var ASCII = (int)second;
                    Console.WriteLine($"Seat decoded: {first}{ASCII}");
                }
            }
        }
    }
}
