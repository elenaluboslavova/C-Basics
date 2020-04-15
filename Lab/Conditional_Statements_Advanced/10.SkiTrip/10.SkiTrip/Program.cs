using System;

namespace _10.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string rating = Console.ReadLine();

            double priceForOneNight = 0;
            double discount = 0;

            if (roomType=="room for one person")
            {
                priceForOneNight = 18;
            }
            else if(roomType=="apartment")
            {
                priceForOneNight = 25;

                if (days<10)
                {
                    discount = 0.30;
                }
                else if(days>=10&&days<=15)
                {
                    discount = 0.35;
                }
                else if(days>15)
                {
                    discount = 0.50;
                }
            }
            else if(roomType=="president apartment")
            {
                priceForOneNight = 35;

                if (days < 10)
                {
                    discount = 0.10;
                }
                else if (days >= 10 && days <= 15)
                {
                    discount = 0.15;
                }
                else if (days > 15)
                {
                    discount = 0.20;
                }
            }

            int nights = days - 1;
            double totalPrice = priceForOneNight * nights;

            totalPrice -= totalPrice * discount;

            if (rating=="positive")
            {
                totalPrice += totalPrice * 0.25;
            }
            else if (rating=="negative")
            {
                totalPrice -= totalPrice * 0.10;
            }

            Console.WriteLine($"{totalPrice:F2}");

        }
    }
}
