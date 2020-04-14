using System;

namespace _06.EasterCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterbread = int.Parse(Console.ReadLine());
            string gradeAsString = "";
            string topChef = "";

            int maxChefGrades = int.MinValue;

            for (int i = 1; i <= easterbread; i++)
            {
                string nameOfChef = Console.ReadLine();
                gradeAsString = Console.ReadLine();
                int sumGrades = 0;

                while (gradeAsString != "Stop")
                {
                    int grade = int.Parse(gradeAsString);
                    if (grade <= 0 || grade > 10)
                    {
                        gradeAsString = Console.ReadLine();
                        continue;
                    }
                    sumGrades += grade;
                    gradeAsString = Console.ReadLine();
                }
                Console.WriteLine($"{nameOfChef} has {sumGrades} points.");

                if (sumGrades > maxChefGrades)
                {
                    maxChefGrades = sumGrades;
                    topChef = nameOfChef;
                    Console.WriteLine($"{topChef} is the new number 1!");
                }
            }
            Console.WriteLine($"{topChef} won competition with {maxChefGrades} points!");
        }
    }
}
