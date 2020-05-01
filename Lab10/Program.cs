using System;
using System.Collections.Generic;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>();
            FillListOfMovies(movies);

            Console.WriteLine("Welcome to the Movie List Application\n");

            bool run = true;
            while (run)
            {
                Console.WriteLine("What category are you interested in? (animated, drama, horror, scifi)\n");
                string input = Console.ReadLine().ToLower().Trim();

                while (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("This can't be empty. Enter animated, drama, horror, scifi\n");
                    input = Console.ReadLine().ToLower().Trim();
                }

                while (input != "animated" && input != "drama" && input != "horror" && input != "scifi")
                {
                    Console.WriteLine("That is not a valid category. Enter animated, drama, horror, scifi\n");
                    input = Console.ReadLine().ToLower().Trim();
                }

                foreach (Movie film in movies)
                {
                    film.PrintMovieTitle(input);
                }

                run = Ask();
            }

        }
        
        public static void FillListOfMovies(List<Movie> movies)
        {
            movies.Add(new Movie("The Squirrel King", "animated"));
            movies.Add(new Movie("Tool Story", "animated"));
            movies.Add(new Movie("Finding Kraken", "animated"));
            movies.Add(new Movie("Sad Stuff", "drama"));
            movies.Add(new Movie("Serious People", "drama"));
            movies.Add(new Movie("Spooky Situations", "horror"));
            movies.Add(new Movie("The Scary Door", "horror"));
            movies.Add(new Movie("Spacestars", "scifi"));
            movies.Add(new Movie("Sun Conflicts", "scifi"));
            movies.Add(new Movie("Bladewalker", "scifi"));
        }

        public static bool Ask()
        {
            Console.WriteLine();
            Console.WriteLine("Continue? (y/n):");
            string input = Console.ReadLine();
            if (input.ToLower() == "y")
            {
                return true;
            }
            else if (input.ToLower() == "n")
            {
                Console.WriteLine("Goodbye.");
                return false;
            }
            else
            {
                Console.WriteLine("Sorry, I did not understand that. Please try again.");
                return Ask();
            }
        }
    }
}
