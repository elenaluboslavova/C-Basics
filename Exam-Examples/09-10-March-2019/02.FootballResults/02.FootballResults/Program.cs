using System;

namespace _02.FootballResults
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstMatch = Console.ReadLine();
            string secondMatch = Console.ReadLine();
            string thirdMatch = Console.ReadLine();
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            int s1 = 0;
            int s2 = 0;
            int s3 = 0;
            int r1 = 0;
            int r2 = 0;
            int r3 = 0;

            if (firstMatch[0]>firstMatch[2])
            {
                sum1 = 1;
            }
            else if(firstMatch[0] < firstMatch[2])
            {
                s1 = 1;
            }
            else if(firstMatch[0]==firstMatch[2])
            {
                r1 = 1;
            }

            if (secondMatch[0] > secondMatch[2])
            {
                sum2 = 1;
            }
            else if(secondMatch[0] < secondMatch[2])
            {
                s2 = 1;
            }
            else if (secondMatch[0] == secondMatch[2])
            {
                r2 = 1;
            }

            if (thirdMatch[0] > thirdMatch[2])
            {
                sum3 = 1;
            }
            else if(thirdMatch[0] < thirdMatch[2])
            {
                s3 = 1;
            }
            else if (thirdMatch[0] == thirdMatch[2])
            {
                r3 = 1;
            }

            Console.WriteLine($"Team won {sum1+sum2+sum3} games.");
            Console.WriteLine($"Team lost {s1+s2+s3} games.");
            Console.WriteLine($"Drawn games: {r1+r2+r3}");

        }
    }
}
