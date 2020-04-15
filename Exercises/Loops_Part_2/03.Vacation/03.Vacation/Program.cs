using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());

            string word = "";
            int counter = 0;
            int days = 0;

            while (availableMoney<neededMoney && counter<5)
            {
                word = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                days++;

                if (word=="spend")
                {
                    availableMoney -= money;
                    counter++;
                    if (availableMoney<0)
                    {
                        availableMoney = 0;
                    }
                }
                else if (word=="save")
                {
                    availableMoney += money;
                    counter = 0;
                }
                
                
                
            }
            if (counter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(days);
            }
            if (availableMoney >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }


        }
    }
}
