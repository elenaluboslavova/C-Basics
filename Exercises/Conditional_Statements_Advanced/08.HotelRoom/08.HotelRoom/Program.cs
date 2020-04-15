using System;

namespace _08.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double sumA = 0;
            double sumS = 0;
            double finalSumS = 0;
            double finalSumA = 0;
            double discountA = 0;
            double discountS = 0;

            if (month=="May" || month=="October")
            {
                sumS = 50;
                if (nights>7 && nights<=14)
                {
                    discountS = 0.05;
                }
                else if(nights>14)
                {
                    discountS = 0.3;
                }
                sumA = 65;
                if (nights>14)
                {
                    discountA = 0.1;
                }
                finalSumA = sumA * nights - sumA * nights * discountA;
                finalSumS = sumS * nights - sumS * nights * discountS;

            }
            
            else if (month == "June" || month == "September")
            {
                sumS = 75.20;
                if (nights>14)
                {
                    discountS = 0.2;
                }
                sumA = 68.70;
                if (nights > 14)
                {
                    discountA = 0.1;
                }
                finalSumA = sumA * nights - sumA * nights * discountA;
                finalSumS = sumS * nights - sumS * nights * discountS;
            }
            
            else if (month == "July" || month == "August")
            {
                sumS = 76;
                sumA = 77;
                if (nights > 14)
                {
                    discountA = 0.1;
                }
                finalSumA = sumA * nights - sumA * nights * discountA;
                finalSumS = sumS * nights;
            }
            
            Console.WriteLine($"Apartment: {finalSumA:F2} lv.");
            Console.WriteLine($"Studio: {finalSumS:F2} lv.");
        }
    }
}
