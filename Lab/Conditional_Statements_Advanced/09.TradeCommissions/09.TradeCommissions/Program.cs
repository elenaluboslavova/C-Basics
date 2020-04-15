using System;

namespace _09.TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sells = double.Parse(Console.ReadLine());

            double commission = 0;

            if (town=="Sofia")
            {
                if (sells>=0&&sells<=500)
                {
                    commission = 0.05;
                }
                else if(sells>500&&sells<=1000)
                {
                    commission = 0.07;
                }
                else if(sells>1000&&sells<=10000)
                {
                    commission = 0.08;
                }
                else if(sells>10000)
                {
                    commission = 0.12;
                }
                else
                {
                    Console.WriteLine("error");
                }

                Console.WriteLine($"{(sells * commission):F2}");
            }
            else if(town=="Varna")
            {
                if (sells >= 0 && sells <= 500)
                {
                    commission = 0.045;
                }
                else if (sells > 500 && sells <= 1000)
                {
                    commission = 0.075;
                }
                else if (sells > 1000 && sells <= 10000)
                {
                    commission = 0.10;
                }
                else if (sells > 10000)
                {
                    commission = 0.13;
                }
                else
                {
                    Console.WriteLine("error");
                }

                Console.WriteLine($"{(sells * commission):F2}");
            }
            else if (town=="Plovdiv")
            {
                if (sells >= 0 && sells <= 500)
                {
                    commission = 0.055;
                }
                else if (sells > 500 && sells <= 1000)
                {
                    commission = 0.08;
                }
                else if (sells > 1000 && sells <= 10000)
                {
                    commission = 0.12;
                }
                else if (sells > 10000)
                {
                    commission = 0.145;
                }
                else
                {
                    Console.WriteLine("error");
                }

                Console.WriteLine($"{(sells * commission):F2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
