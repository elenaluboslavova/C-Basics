using System;

namespace _04.BestPlaneTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double priceInEuro = 0;
            int minutes = 0;
            string finalTicketNumber = "";
            double finalTicketPrice = 0;

            int min = int.MaxValue;

            while (input != "End")
            {
                priceInEuro = double.Parse(Console.ReadLine());
                minutes = int.Parse(Console.ReadLine());

                if (minutes < min)
                {
                    min = minutes;
                    finalTicketNumber = input;
                    finalTicketPrice = priceInEuro * 1.96;
                }


                input = Console.ReadLine();
            }
            if (min>= 60)
            {
                Console.WriteLine($"Ticket found for flight {finalTicketNumber}" +
                    $" costs {finalTicketPrice:F2} leva with {min / 60}h {min-60}m stay");
            }
            else
            {
                Console.WriteLine($"Ticket found for flight {finalTicketNumber}" +
                    $" costs {finalTicketPrice:F2} leva with 0h {min}m stay");
            }
        }
    }
}
