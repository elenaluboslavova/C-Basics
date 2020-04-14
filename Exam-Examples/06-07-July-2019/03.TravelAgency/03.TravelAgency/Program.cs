using System;

namespace _03.TravelAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            string packet = Console.ReadLine();
            string VIP = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double sum = 0;

            if (city == "Bansko" || city == "Borovets")
            {
                switch (packet)
                {
                    case "noEquipment":
                        sum = days * 80;
                        if (VIP == "yes")
                        {
                            sum = sum * 0.95;
                        }
                        if (days > 7)
                        {
                            sum -= 80;
                        }
                        break;
                    case "withEquipment":
                        sum = days * 100;
                        if (VIP == "yes")
                        {
                            sum = sum * 0.9;
                        }
                        if (days > 7)
                        {
                            sum -= 100;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        Environment.Exit(0);
                        break;
                }

            }

            else if (city == "Varna" || city == "Burgas")
            {
                switch (packet)
                {
                    case "noBreakfast":
                        sum = days * 100;
                        if (VIP == "yes")
                        {
                            sum = sum * 0.93;
                        }
                        if (days > 7)
                        {
                            sum -= 100;
                        }
                        break;
                    case "withBreakfast":
                        sum = days * 130;
                        if (VIP == "yes")
                        {
                            sum = sum * 0.88;
                        }
                        if (days > 7)
                        {
                            sum -= 130;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        Environment.Exit(0);
                        break;
                        
                }
            }

            else
            {
                Console.WriteLine("Invalid input!");
                Environment.Exit(0);
            }
            if (days <= 0 )
            {
                Console.WriteLine("Days must be positive number!");
                Environment.Exit(0);
            }

            Console.WriteLine($"The price is {sum:F2}lv! Have a nice time!");
        }
    }
}
