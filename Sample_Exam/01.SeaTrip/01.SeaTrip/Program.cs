using System;

namespace _01.SeaTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForFood = double.Parse(Console.ReadLine());
            double moneyForSouvenirs = double.Parse(Console.ReadLine());
            double moneyForHotel = double.Parse(Console.ReadLine());

            double Z = moneyForHotel * 0.9 + moneyForHotel * 0.85 + moneyForHotel * 0.8;
            double moneyForGas = 420 * 1.0 * 7 / 100 * 1.85;


            double sum = moneyForFood * 3 + moneyForSouvenirs * 3 + Z + moneyForGas;

            Console.WriteLine($"Money needed: {sum:F2}");
        }
    }
}
