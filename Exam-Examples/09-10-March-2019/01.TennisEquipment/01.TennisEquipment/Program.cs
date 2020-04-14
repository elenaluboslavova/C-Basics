using System;

namespace _01.TennisEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double tennisRacketPrice = double.Parse(Console.ReadLine());
            int tennisRacketCount = int.Parse(Console.ReadLine());
            int shoesCount = int.Parse(Console.ReadLine());

            double shoesPrice = tennisRacketPrice * 1 / 6;
            double sum = tennisRacketPrice * tennisRacketCount +
                shoesPrice * shoesCount;
            double otherEquipment = sum * 20 / 100;
            double finalSum = sum + otherEquipment;
            double paySum = finalSum * 1 / 8;
            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(paySum)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(finalSum*7/8)}");
        }
    }
}
