using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // hard coded values for top 10 tv shows
        List<string> topTvShows = new List<string>
        {
            "The Last of Us",
            "Stranger Things",
            "Breaking Bad",
            "The Mandalorian",
            "Better Call Saul",
            "The Crown",
            "Ozark",
            "The Boys",
            "Wednesday",
            "Succession"
        };

        Random rng = new Random();

        while (true)
        {
            Console.Write("Would you like to watch a movie or TV show? (Type 'movie', 'tv', or 'quit'): ");
            string choice = Console.ReadLine().Trim().ToLower();

            if (choice == "quit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else if (choice == "movie")
            {
                Console.WriteLine();
                List<string> movies = new List<string>();
                for (int i = 1; i <= 3; i++)
                {
                    Console.Write($"Enter movie #{i}: ");
                    string movie = Console.ReadLine();
                    movies.Add(movie);
                }

                Console.WriteLine("\nYou entered these movies:");
                foreach (string movie in movies)
                {
                    Console.WriteLine("- " + movie);
                }

                int pickedIndex = rng.Next(movies.Count);
                string selectedMovie = movies[pickedIndex];

                Console.WriteLine($"\nTonight's pick is: {selectedMovie}!\n");
            }
            else if (choice == "tv")
            {
                int index = rng.Next(topTvShows.Count);
                string randomShow = topTvShows[index];

                Console.WriteLine($"\nHow about watching: {randomShow}?\n");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please type 'movie', 'tv', or 'quit'.\n");
            }
        }
    }
}
