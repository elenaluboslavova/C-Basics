using System;

namespace _04.TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string word = Console.ReadLine();
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            double sum4 = 0;

            if (n>=100 && word=="day" || word=="night")
            {
                sum1 = 0.06 * n;
            }
            else if(n>= 20 && word == "day" || word == "night")
            {
                sum2 = 0.09 * n;
            }
            else
            {
                if (word == "day")
                {
                    sum3 = 0.70 + 0.79 * n;
                }
                else if (word == "night")
                {
                    sum4 = 0.70 + 0.90 * n;
                }
            }

            if (sum1>sum2 && sum1>sum3)
            {

            }

            
            
            
        }
    }
}
