using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace MODUL7_KELOMPOK6
{
    internal class Watchlist_103022400110
    {
        public string WatchlistName { get; set; }
        public string CreatedBy { get; set; }
        public List<FilmFavorit_103022400110> Movies { get; set; }
        public Watchlist_103022400110(string watchlistName, string createdBy, List<FilmFavorit_103022400110> movies)
        {
            WatchlistName = watchlistName;
            CreatedBy = createdBy;
            Movies = movies;
        }

        /*Pada method tersebut, lakukan print hasil deserialisasi dari object yang dibuat dengan 
format output sebagai berikut.
Watchlist Name : Weekend Marathon
Created By : Kelompok 07
Movies : 
F101 The Matrix (1999 - 8,7)
F102 Parasite (2019 - 8,5)
F103 Avengers: Endgame (2019 - 8,4)
*/
        //Json
        public static void ReadJSON(string json)
        {
            // JSON 1
            string path1 = @"..\..\..\lib\jurnal7_2_103022400110.json";
            // Membaca isi file JSON
            string json1 = File.ReadAllText(path1);

            // Deserialize JSON string to List<Watchlist> object
            var data1 = JsonSerializer.Deserialize<List<Watchlist_103022400110>>(json1);

            // Print the deserialized object
            foreach (var watchlist in data1)
            {
                Console.WriteLine($"Watchlist Name: {watchlist.WatchlistName}");
                Console.WriteLine($"Created By: {watchlist.CreatedBy}");
                Console.WriteLine("Movies:");
                foreach (var movie in watchlist.Movies)
                {
                    Console.WriteLine($"{movie.Title} ({movie.Year} - {movie.Rating})");
                }
                Console.WriteLine();
            }
        }
    }
}
