using System;

namespace _03.MobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string contractTerm = Console.ReadLine();
            string contractType = Console.ReadLine();
            string addedMobileInternet = Console.ReadLine();
            int months = int.Parse(Console.ReadLine());

            double sum = 0;

            if (contractTerm == "one")
            {
                if (contractType == "Small")
                {
                    sum = 9.98 * months;
                    if (addedMobileInternet == "yes")
                    {
                        sum = sum + months * 5.50;
                    }
                }
                else if (contractType == "Middle")
                {
                    sum = 18.99 * months;
                    if (addedMobileInternet == "yes")
                    {
                        sum = sum + months * 4.35;
                    }
                }
                else if (contractType == "Large")
                {
                    sum = 25.98 * months;
                    if (addedMobileInternet == "yes")
                    {
                        sum = sum + months * 4.35;
                    }
                }
                else if (contractType == "ExtraLarge")
                {
                    sum = 35.99 * months;
                    if (addedMobileInternet == "yes")
                    {
                        sum = sum + months * 3.85;
                    }
                }
            }
            else if (contractTerm == "two")
            {
                if (contractType == "Small")
                {
                    sum = 8.58 * months;
                    if (addedMobileInternet == "yes")
                    {
                        sum = sum + months * 5.50;
                    }
                }
                else if (contractType == "Middle")
                {
                    sum = 17.09 * months;
                    if (addedMobileInternet == "yes")
                    {
                        sum = sum + months * 4.35;
                    }
                }
                else if (contractType == "Large")
                {
                    sum = 23.59 * months;
                    if (addedMobileInternet == "yes")
                    {
                        sum = sum + months * 4.35;
                    }
                }
                else if (contractType == "ExtraLarge")
                {
                    sum = 31.79 * months;
                    if (addedMobileInternet == "yes")
                    {
                        sum = sum + months * 3.85;
                    }
                }
                sum = sum - sum * 0.0375;

            }
            Console.WriteLine($"{sum:F2} lv.");
        }
    }
}
