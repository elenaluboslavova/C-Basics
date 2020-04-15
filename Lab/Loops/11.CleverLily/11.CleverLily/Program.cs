using System;

namespace _11.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            double moneyFromBirthdays = 0;
            int moneyGift = 10;

            int toysCount = 0;

            for (int birthday = 1; birthday <= age; birthday++)
            {
                if (birthday % 2 == 0)
                {
                    moneyFromBirthdays += moneyGift;
                    moneyGift += 10;
                    moneyFromBirthdays -= 1;
                }
                else
                {
                    toysCount++;
                }
            }

            int moneyFromToys = toysCount * toyPrice;
            moneyFromBirthdays += moneyFromToys;

            if (moneyFromBirthdays>=washingMachinePrice)
            {
                Console.WriteLine($"Yes! {(moneyFromBirthdays-washingMachinePrice):F2}");
            }
            else
            {
                Console.WriteLine($"No! {(washingMachinePrice-moneyFromBirthdays):F2}");
            }
        }
    }
}
