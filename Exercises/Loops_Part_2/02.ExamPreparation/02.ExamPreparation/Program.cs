using System;

namespace _02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int poorGrades = int.Parse(Console.ReadLine());
            int failedTimes = 0;
            int counter = 0;
            double gradesSum = 0;
            string lastProblem = "";
            bool isFailed = true;

            while (failedTimes < poorGrades)
            {
                string name = Console.ReadLine();
                if (name=="Enough")
                {
                    isFailed = false;
                    break;
                }

                int grade = int.Parse(Console.ReadLine());

                if (grade <= 4)
                {
                    failedTimes++;
                }
                gradesSum += grade;
                counter++;
                lastProblem = name;
                
            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {poorGrades} poor grades.");

            }
            else
            {
                Console.WriteLine($"Average score: {gradesSum/counter:F2}");
                Console.WriteLine($"Number of problems: {counter}");
                Console.WriteLine($"Last problem: {lastProblem}");
                Environment.Exit(0);
            }
        }
    }
}
