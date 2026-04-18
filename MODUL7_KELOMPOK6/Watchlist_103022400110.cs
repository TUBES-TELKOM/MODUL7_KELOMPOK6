using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace MODUL7_KELOMPOK6
{
    public class Movie
    {
        public string id { get; set; }
        public string title { get; set; }
        public int year { get; set; }
        public double rating { get; set; }
    }

    public class Watchlist_103022400110
    {
        public string watchlistName { get; set; } = string.Empty;
        public string createdBy { get; set; } = string.Empty;
        public List<Movie> movies { get; set; } = new List<Movie>();

        public static void ReadJSON()
        {
            // JSON 1
            string path1 = @"..\..\..\lib\jurnal7_2_103022400110.json";
            // Membaca isi file JSON
            string json1 = File.ReadAllText(path1);

            // Deserialize JSON string to Watchlist_103022400110 object
            var data1 = JsonSerializer.Deserialize<Watchlist_103022400110>(json1) ?? new Watchlist_103022400110();

            Console.WriteLine("Watchlist Name : " + data1.watchlistName);
            Console.WriteLine("Created By : " + data1.createdBy);
            Console.WriteLine("Movies : ");

            foreach (var movie in data1.movies)
            {
                Console.WriteLine(movie.id + " " + movie.title + " (" + movie.year + " - " + movie.rating + ")");
            }
        }
    }
}
