using System;

namespace _09.GraduationPt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int counter = 1;
            double sum = 0;
            int count = 0;

            while (counter <= 12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 4.00)
                {
                    sum += grade;
                    counter++;
                }
                if (grade == 2 || grade == 3)
                {
                    count++;
                    if (count==2)
                    {
                        Console.WriteLine($"{name} has been excluded at {counter} grade");
                        Environment.Exit(0);
                    }
                }
            }
            
            double average = sum / 12;
            Console.WriteLine($"{name} graduated. Average grade: {average:F2}");
        }
    }
}
