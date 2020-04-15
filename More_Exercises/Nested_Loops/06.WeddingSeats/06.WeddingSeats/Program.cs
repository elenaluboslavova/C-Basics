using System;

namespace _06.WeddingSeats
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int firstSectorRows = int.Parse(Console.ReadLine());
            int oddRowSeats = int.Parse(Console.ReadLine());

            int count1 = 0;
            int count2 = 0;

            for (char i = 'A'; i <= lastSector; i++)
            {
                for (int j = 1; j <= firstSectorRows; j++)
                {
                    if (j % 2 == 1)
                    {
                        for (char k = 'a'; k < 'a' + oddRowSeats; k++)
                        {
                            Console.WriteLine($"{i}{j}{k}");
                            count1++;

                        }
                    }
                    else
                    {
                        for (char l = 'a'; l < 'a' + oddRowSeats + 2; l++)
                        {
                            Console.WriteLine($"{i}{j}{l}");
                            count2++;
                        }
                    }
                    
                    

                }
                firstSectorRows++;
            }
            Console.WriteLine(count1+count2);
        }
    }
}
