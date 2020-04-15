using System;

namespace _04.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int juryCount = int.Parse(Console.ReadLine());

            string presentation = Console.ReadLine();
            double grade = 0;
            double finalGrade = 0;
            double final = 0;
            int counter = 0;

            while (presentation != "Finish")
            {
                finalGrade = 0;
                counter++;
                for (int i = 0; i < juryCount; i++)
                {
                    grade = double.Parse(Console.ReadLine());
                    finalGrade += grade;
                }
                final += finalGrade;
                Console.WriteLine($"{presentation} - {finalGrade/juryCount:F2}.");
                presentation = Console.ReadLine();
            }
            if (presentation == "Finish")
            {
                Console.WriteLine($"Student's final assessment is {final / counter / juryCount:F2}.");
                return;
            }
            
        }
    }
}
