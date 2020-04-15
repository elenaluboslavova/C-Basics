using System;

namespace _07.SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string group = Console.ReadLine();
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());

            double sum = 0;
            string sport = "";

            if (season == "Winter")
            {
                if (group == "girls")
                {
                    sum = nights * students * 9.60;
                    sport = "Gymnastics";
                }
                else if (group == "boys")
                {
                    sum = nights * students * 9.60;
                    sport = "Judo";
                }
                else if (group == "mixed")
                {
                    sum = nights * students * 10.00;
                    sport = "Ski";
                }
            }


            else if (season == "Spring")
            {
                if (group == "girls")
                {
                    sum = nights * students * 7.20;
                    sport = "Athletics";
                }
                else if (group == "boys")
                {
                    sum = nights * students * 7.20;
                    sport = "Tennis";
                }
                else if (group == "mixed")
                {
                    sum = nights * students * 9.50;
                    sport = "Cycling";
                }
            }


            else if (season == "Summer")
            {
                if (group == "girls")
                {
                    sum = nights * students * 15.00;
                    sport = "Volleyball";
                }
                else if (group == "boys")
                {
                    sum = nights * students * 15.00;
                    sport = "Football";
                }
                else if (group == "mixed")
                {
                    sum = nights * students * 20.00;
                    sport = "Swimming";
                }
            }

            if (students >= 50)
            {
                sum = sum * 0.5;
            }
            else if (students >= 20 && students < 50)
            {
                sum = sum - sum * 0.15;
            }
            else if (students >= 10 && students < 20)
            {
                sum = sum - sum * 0.05;
            }

            Console.WriteLine($"{sport} {sum:F2} lv.");
        }
    }
}
