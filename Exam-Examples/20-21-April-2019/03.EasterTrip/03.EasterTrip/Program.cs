using System;

namespace _03.EasterTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string dates = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double sum = 0;

            if (destination == "France")
            {
                if (dates == "21-23")
                {
                    sum = nights * 30;
                }
                else if (dates == "24-27")
                {
                    sum = nights * 35;
                }
                else if (dates == "28-31")
                {
                    sum = nights * 40;
                }
            }

            else if (destination == "Italy")
            {
                if (dates == "21-23")
                {
                    sum = nights * 28;
                }
                else if (dates == "24-27")
                {
                    sum = nights * 32;
                }
                else if (dates == "28-31")
                {
                    sum = nights * 39;
                }
            }

            else if (destination == "Germany")
            {
                if (dates == "21-23")
                {
                    sum = nights * 32;
                }
                else if (dates == "24-27")
                {
                    sum = nights * 37;
                }
                else if (dates == "28-31")
                {
                    sum = nights * 43;
                }
            }

            Console.WriteLine($"Easter trip to {destination} : {sum:F2} leva.");
        }
    }
}
