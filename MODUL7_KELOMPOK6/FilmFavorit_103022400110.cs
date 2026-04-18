using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

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

        //ReadJson ambil dari data json jurnal7_1_103022400110.json
        public static void ReadJSON(string json)
        {
            // JSON 1
            string path1 = @"..\..\..\lib\jurnal7_1_103022400110.json";
            // Membaca isi file JSON
            string json1 = File.ReadAllText(path1);

            // Deserialize JSON string to List<FilmFavorit_103022400110> object
            var data1 = JsonSerializer.Deserialize<List<FilmFavorit_103022400110>>(json1);

            // Print the deserialized object
            Console.WriteLine("Data Film Favorit:");
            foreach (var film in data1)
            {
                Console.WriteLine($"{film.Title} ({film.Year} - {film.Rating})");
            }
        }
    }
}
