using System;

namespace _05.MovieRatings
{
    class Program
    {
        static void Main(string[] args)
        {
            int movies = int.Parse(Console.ReadLine());

            string movieName = "";
            double movieRating = 0;

            double max = double.MinValue;
            double min = double.MaxValue;
            string maxMovie = "";
            string minMovie = "";
            double average = 0;

            for (int i = 0; i < movies; i++)
            {
                movieName = Console.ReadLine();
                movieRating = double.Parse(Console.ReadLine());
                average += movieRating;
                if (movieRating > max)
                {
                    max = movieRating;
                    maxMovie = movieName;
                }
                if (movieRating < min)
                {
                    min = movieRating;
                    minMovie = movieName;
                }
            }
            Console.WriteLine($"{maxMovie} is with highest rating: {max:F1}");
            Console.WriteLine($"{minMovie} is with lowest rating: {min:F1}");
            Console.WriteLine($"Average rating: {average / movies:F1}");
        }
    }
}
