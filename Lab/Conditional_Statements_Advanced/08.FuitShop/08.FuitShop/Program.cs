using System;

namespace _08.FuitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            bool isWeekDay = day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday";
            bool isWeekEnd = day == "Saturday" || day == "Sunday";

            double banana = 0;
            double apple = 0;
            double orange = 0;
            double grapefruit = 0;
            double kiwi = 0;
            double pineapple = 0;
            double grapes = 0;

            if (isWeekDay)
            {
                banana = 2.50;
                apple = 1.20;
                orange = 0.85;
                grapefruit = 1.45;
                kiwi = 2.70;
                pineapple = 5.50;
                grapes = 3.85;
                if (fruit == "banana")
                {
                    Console.WriteLine($"{(banana * quantity):F2}");
                }
                else if (fruit == "apple")
                {
                    Console.WriteLine($"{(apple * quantity):F2}");
                }
                else if (fruit == "orange")
                {
                    Console.WriteLine($"{(orange * quantity):F2}");
                }
                else if (fruit == "grapefruit")
                {
                    Console.WriteLine($"{(grapefruit * quantity):F2}");
                }
                else if (fruit == "kiwi")
                {
                    Console.WriteLine($"{(kiwi * quantity):F2}");
                }
                else if (fruit == "pineapple")
                {
                    Console.WriteLine($"{(pineapple * quantity):F2}");
                }
                else if (fruit == "grapes")
                {
                    Console.WriteLine($"{(grapes * quantity):F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if(isWeekEnd)
            {
                banana = 2.70;
                apple = 1.25;
                orange = 0.90;
                grapefruit = 1.60;
                kiwi = 3.00;
                pineapple = 5.60;
                grapes = 4.20;
                if (fruit == "banana")
                {
                    Console.WriteLine($"{(banana * quantity):F2}");
                }
                else if (fruit == "apple")
                {
                    Console.WriteLine($"{(apple * quantity):F2}");
                }
                else if (fruit == "orange")
                {
                    Console.WriteLine($"{(orange * quantity):F2}");
                }
                else if (fruit == "grapefruit")
                {
                    Console.WriteLine($"{(grapefruit * quantity):F2}");
                }
                else if (fruit == "kiwi")
                {
                    Console.WriteLine($"{(kiwi * quantity):F2}");
                }
                else if (fruit == "pineapple")
                {
                    Console.WriteLine($"{(pineapple * quantity):F2}");
                }
                else if (fruit == "grapes")
                {
                    Console.WriteLine($"{(grapes * quantity):F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
            

            
        }
    }
}
