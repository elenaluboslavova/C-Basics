using System;

namespace _04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());

            double grade = 0;
            double counter1 = 0;
            double counter2 = 0;
            double counter3 = 0;
            double counter4 = 0;
            double counter = 0;
            double average = 0;

            for (int i = 0; i < students; i++)
            {
                grade = double.Parse(Console.ReadLine());
                if (grade <= 2.99)
                {
                    counter1++;
                }
                else if (3.00 <= grade && grade <= 3.99)
                {
                    counter2++;
                }
                else if (4.00 <= grade && grade <= 4.99)
                {
                    counter3++;
                }
                else if (grade >= 5.00)
                {
                    counter4++;
                }
                average += grade;
                counter = counter1 + counter2 + counter3 + counter4;
            }
            Console.WriteLine($"Top students: {counter4 / counter * 100 :F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {counter3 / counter * 100 :F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {counter2 / counter * 100 :F2}%");
            Console.WriteLine($"Fail: {counter1 / counter * 100 :F2}%");
            Console.WriteLine($"Average: {average / counter :F2}");
        }
    }
}
