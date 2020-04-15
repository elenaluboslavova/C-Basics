using System;

namespace _06.Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            double electricity = 0;
            double water = 20;
            double internet = 15;
            double others = 0;
            double allElectricity = 0;
            double allWater = 0;
            double allInternet = 0;
            double allOthers = 0;

            for (int i = 0; i < months; i++)
            {
                electricity = double.Parse(Console.ReadLine());
                others = electricity + water + internet + (electricity + water + internet) * 0.2;
                allElectricity += electricity;
                allWater = months * water;
                allInternet = months * internet;
                allOthers += others;
            }
            Console.WriteLine($"Electricity: {allElectricity:F2} lv");
            Console.WriteLine($"Water: {allWater:F2} lv");
            Console.WriteLine($"Internet: {allInternet:F2} lv");
            Console.WriteLine($"Other: {allOthers:F2} lv");
            Console.WriteLine($"Average: {(allElectricity+allWater+allInternet+allOthers)/months:F2} lv");
        }
    }
}
