﻿using System;

namespace _04.NumbersDividedBy3WithoutReminder
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                while (i%3==0)
                {
                    Console.WriteLine(i);
                    i++;
                }
            }
        }
    }
}