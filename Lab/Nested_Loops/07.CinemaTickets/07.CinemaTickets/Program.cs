using System;

namespace _07.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();

            int totalTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;
            int studentTickets = 0;

            while (movie != "Finish")
            {
                int availableSeats = int.Parse(Console.ReadLine());

                string ticket = Console.ReadLine();
                int currentTickets = 0;

                while (ticket != "End")
                {
                    switch (ticket)
                    {
                        case "standard":
                            standardTickets++;
                            break;
                        case "kid":
                            kidTickets++;
                            break;
                        case "student":
                            studentTickets++;
                            break;
                    }
                    currentTickets++;
                    if (currentTickets == availableSeats)
                    {
                        break;
                    }
                    ticket = Console.ReadLine();
                }
                totalTickets += currentTickets;

                double seatsTaken = currentTickets * 1.0 / availableSeats * 100;
                Console.WriteLine($"{movie} - {seatsTaken:F2}% full.");

                movie = Console.ReadLine();
            }


            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentTickets * 1.0/ totalTickets * 100:F2}% student tickets.");
            Console.WriteLine($"{standardTickets * 1.0 / totalTickets * 100:F2}% standard tickets.");
            Console.WriteLine($"{kidTickets * 1.0/ totalTickets * 100:F2}% kids tickets.");
        }
    }
}
