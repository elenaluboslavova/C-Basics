using System;

namespace _01.ChangeBureau
{
    class Program
    {
        static void Main(string[] args)
        {
            int countBitcoin = int.Parse(Console.ReadLine());
            double chineseUan = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double sum = countBitcoin * 1.0 * 1168 / 1.95 + chineseUan * 0.15 * 1.76 / 1.95;
            double finalSum = sum - percent / 100 * sum;
            Console.WriteLine($"{finalSum:F2}");
        }
    }
}
