using System;

namespace _06.TournamentOfChristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            string sport = "";
            string result = "";
            double sum = 0;
            int countWin = 0;
            int countLose = 0;
            double finalSum = 0;
            int finalWin = 0;
            int finalLose = 0;
            double final = 0;
            int dayWin = 0;
            int dayLose = 0;

            for (int i = 1; i <= days; i++)
            {
                dayWin = 0;
                dayLose = 0;
                finalSum = 0; 
                countWin = 0;
                countLose = 0;
                while (command != "Finish")
                {
                    countWin = 0;
                    countLose = 0;
                    sport = command;
                    result = Console.ReadLine();

                    if (result == "win")
                    {
                        countWin++;
                        finalWin += countWin;
                        sum = 20;
                        finalSum += sum;
                    }

                    else if (result == "lose")
                    {
                        countLose++;
                        finalLose += countLose;

                    }
                    dayWin += countWin;
                    dayLose += countLose;
                    command = Console.ReadLine();
                }
                if (dayWin > dayLose)
                {
                    finalSum = finalSum + finalSum * 0.1;
                }
                final += finalSum;
                command = Console.ReadLine();
            }
            if (finalWin > finalLose)
            {
                final = final + final * 0.2;
                Console.WriteLine($"You won the tournament! Total raised money: {final:F2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {final:F2}");
            }
            
        }
    }
}
