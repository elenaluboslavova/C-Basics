using System;

namespace _01.OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine();
            int allBooks = int.Parse(Console.ReadLine());
            string book = "";
            int counter = 0;

            while (book != favouriteBook)
            {
                book = Console.ReadLine();
                
                allBooks--;
                if (book==favouriteBook)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    Environment.Exit(0);
                }
                counter++;
                if (allBooks==0)
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {counter} books.");
                    Environment.Exit(0);
                }
                
            }
            
        }
    }
}
