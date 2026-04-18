using System;
using System.Collections.Generic;
using System.Text;

namespace MODUL7_KELOMPOK6
{
    internal class FilmFavorit_103022400110
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }
        public float Rating { get; set; }
        public float durationMinutes { get; set; }
        public bool isWatched { get; set; }

        //konstruktor
        public FilmFavorit_103022400110(string title, string director, string year, string genre, float rating, float durationMinutes, bool isWatched)
        {
            Title = title;
            Director = director;
            Year = year;
            Genre = genre;
            Rating = rating;
            this.durationMinutes = durationMinutes;
            this.isWatched = isWatched;
        }

        //ReadJson
        public static void ReadJSON(string json)
        {
            // Deserialize JSON string to FilmFavorit_103022400110 object
            FilmFavorit_103022400110 film = System.Text.Json.JsonSerializer.Deserialize<FilmFavorit_103022400110>(json);
            // Print the deserialized object
            Console.WriteLine("Title: " + film.Title);
            Console.WriteLine("Director: " + film.Director);
            Console.WriteLine("Year: " + film.Year);
            Console.WriteLine("Genre: " + film.Genre);
            Console.WriteLine("Rating: " + film.Rating);
            Console.WriteLine("Duration (minutes): " + film.durationMinutes);
            Console.WriteLine("Watched: " + (film.isWatched ? "Yes" : "No"));
        }

    }
}
