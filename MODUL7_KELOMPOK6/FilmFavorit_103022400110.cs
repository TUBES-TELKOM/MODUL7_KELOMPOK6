using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace MODUL7_KELOMPOK6
{
    public class FilmFavorit_103022400110
    {
        public string title { get; set; }
        public string director { get; set; }
        public string year { get; set; }
        public string genre { get; set; }
        public float rating { get; set; }
        public float durationMinutes { get; set; }
        public bool isWatched { get; set; }

        // Reading JSON from file and deserializing it into an object
        public static void ReadJSON(string json)
        {
            // JSON 1
            string path1 = @"..\..\..\lib\jurnal7_1_103022400110.json";
            // Membaca isi file JSON
            string json1 = File.ReadAllText(path1);

            var data1 = JsonSerializer.Deserialize<FilmFavorit_103022400110>(json1);

            // Print the deserialized object
            Console.WriteLine("Title: " + data1.title);
            Console.WriteLine("Director: " + data1.director);
            Console.WriteLine("Year: " + data1.year);
            Console.WriteLine("Genre: " + data1.genre);
            Console.WriteLine("Rating: " + data1.rating);
            Console.WriteLine("Duration (minutes): " + data1.durationMinutes);
            Console.WriteLine("Watched: " + data1.isWatched);

        }
    }
}
