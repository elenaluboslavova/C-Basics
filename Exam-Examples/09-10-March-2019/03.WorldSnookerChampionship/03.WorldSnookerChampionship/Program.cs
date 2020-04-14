using System;

namespace _03.WorldSnookerChampionship
{
    class Program
    {
        static void Main(string[] args)
        {
            string stage = Console.ReadLine();
            string ticketType = Console.ReadLine();
            int ticketsCount = int.Parse(Console.ReadLine());
            char picture = char.Parse(Console.ReadLine());

            double sumPerTicket = 0;
            double finalSum = 0;

            if (stage == "Quarter final")
            {
                switch(ticketType)
                {
                    case "Standard":
                        sumPerTicket = 55.50;
                        break;
                    case "Premium":
                        sumPerTicket = 105.20;
                        break;
                    case "VIP":
                        sumPerTicket = 118.90;
                        break;
                }
            }

            else if (stage == "Semi final")
            {
                switch (ticketType)
                {
                    case "Standard":
                        sumPerTicket = 75.88;
                        break;
                    case "Premium":
                        sumPerTicket = 125.22;
                        break;
                    case "VIP":
                        sumPerTicket = 300.40;
                        break;
                }
            }

            else if (stage == "Final")
            {
                switch (ticketType)
                {
                    case "Standard":
                        sumPerTicket = 110.10;
                        break;
                    case "Premium":
                        sumPerTicket = 160.66;
                        break;
                    case "VIP":
                        sumPerTicket = 400;
                        break;
                }
            }

            finalSum = sumPerTicket * ticketsCount;
            

            if (finalSum > 2500 && finalSum <= 4000)
            {
                finalSum = finalSum - finalSum * 0.1;
            }
            if (picture == 'Y' && finalSum <= 4000)
            {
                finalSum += 40 * ticketsCount;
            }
            else if (finalSum > 4000)
            {
                finalSum = finalSum - finalSum * 0.25;
            }

            Console.WriteLine($"{finalSum:F2}");
        }
    }
}
