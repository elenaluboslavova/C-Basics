﻿using System;

namespace _03.SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            

            int primeSum = 0;
            int nonPrimeSum = 0;

            while ((input = Console.ReadLine()) != "stop")
            {
                int number = int.Parse(input);
                bool isPrime = true;

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }

                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        nonPrimeSum += number;
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeSum += number;
                }
                else
                {
                    isPrime = true;
                }

            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
