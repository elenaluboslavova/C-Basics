using System;

namespace _03.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int loadCount = int.Parse(Console.ReadLine());
            int goods = 0;
            double priceBus = 0;
            double priceTruck = 0;
            double priceTrain = 0;
            double allGoods = 0;
            double finalPriceBus = 0;
            double finalPriceTruck = 0;
            double finalPriceTrain = 0;
            int busCounter = 0;
            int truckCounter = 0;
            int trainCounter = 0;

            for (int i = 0; i < loadCount; i++)
            {
                goods = int.Parse(Console.ReadLine());
                if (goods <= 3)
                {
                    priceBus = 200 * goods;
                    finalPriceBus += priceBus;
                    busCounter+=goods;
                }
                else if (4 <= goods && goods <= 11)
                {
                    priceTruck = 175 * goods;
                    finalPriceTruck += priceTruck;
                    truckCounter += goods;
                }
                else if (goods >= 12)
                {
                    priceTrain = 120 * goods;
                    finalPriceTrain += priceTrain;
                    trainCounter += goods;
                }
                allGoods += goods;
            }
            double total = (finalPriceBus + finalPriceTruck + finalPriceTrain) / allGoods;
            Console.WriteLine($"{total:F2}");
            Console.WriteLine($"{busCounter / allGoods * 100:F2}%");
            Console.WriteLine($"{truckCounter / allGoods * 100:F2}%");
            Console.WriteLine($"{trainCounter / allGoods * 100:F2}%");
        }
    }
}
