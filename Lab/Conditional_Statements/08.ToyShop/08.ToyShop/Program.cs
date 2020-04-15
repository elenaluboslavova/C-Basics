using System;

namespace _08.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacationPrice = double.Parse(Console.ReadLine());
            int puzzlesCount = int.Parse(Console.ReadLine());
            int dollsCount = int.Parse(Console.ReadLine());
            int bearsCount = int.Parse(Console.ReadLine());
            int minionsCount = int.Parse(Console.ReadLine());
            int trucksCount = int.Parse(Console.ReadLine());

            double sum = puzzlesCount * 2.60 + dollsCount * 3 + bearsCount * 4.10 +
                minionsCount * 8.20 + trucksCount * 2;
            int count = puzzlesCount + dollsCount + bearsCount + minionsCount +
                trucksCount;
            if (count>=50)
            {
                double sumWithDiscount = sum - sum * 25 / 100;
                double rent = sumWithDiscount * 10 / 100;
                double finalSum = sumWithDiscount - rent;
                if (finalSum >= vacationPrice)
                {
                    Console.WriteLine($"Yes! {(finalSum-vacationPrice):F2} lv left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! {Math.Abs(vacationPrice-finalSum):F2} lv needed.");
                }
            }
            else
            {
                double rent = sum * 10 / 100;
                double finalSum = sum - rent;
                if (finalSum >= vacationPrice)
                {
                    Console.WriteLine($"Yes! {(finalSum - vacationPrice):F2} lv left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! {Math.Abs(finalSum-vacationPrice):F2} lv needed.");
                }

            }
        }
    }
}
