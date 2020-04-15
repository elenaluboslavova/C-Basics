using System;

namespace _04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = 0;
            int stepsSum = 0;

            while (stepsSum<10000)
            {
                string command = Console.ReadLine();
                

                if (command=="Going home")
                {
                    int stepsToHome = int.Parse(Console.ReadLine());
                    stepsSum += stepsToHome;
                    break;

                }
                else
                {
                    steps = int.Parse(command);
                    stepsSum += steps;
                    if (stepsSum >= 10000)
                    {
                        break;
                    }
                }
            }
            if (stepsSum>=10000)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            else
            {
                Console.WriteLine($"{10000-stepsSum} more steps to reach goal.");
            }
        }
    }
}
