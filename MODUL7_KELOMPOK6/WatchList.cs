using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

//{
//    "watchlistName": "We",
//    "createdBy": "Kelompok 06",
//    "movies": [

namespace MODUL7_KELOMPOK6
{

    internal class Movie
    {
        public string id {  get; set; } = string.Empty;
        public string title { get; set; } = string.Empty;
        public int year { get; set; }
        public string genre {  get; set; } = string.Empty;
        public double rating { get; set; }
    }
    internal class WatchList
    {
        public string watchlistName { get; set; } = string.Empty;
        public string createdBy { get; set; } = string.Empty;
        public List<Movie> movies { get; set; } = new List<Movie>();

        public void ReadJson()
        {
            string path1 = @"..\..\..\lib\jurnal7_2_103022400032.json";
            string json1 = File.ReadAllText(path1);

            var data1 = JsonSerializer.Deserialize<WatchList>(json1)
                        ?? new WatchList();



            Console.WriteLine(
                "watchlistName: " + data1.watchlistName + "\n" +
                "createdBy: " + data1.createdBy + "\n" +
                "movies :" + "\n"
                );

            for (int i = 0; i < data1.movies.Count; i++)
            {
                Console.WriteLine(
                    "id: " + data1.movies[i].id + "\n" +
                    "title: " + data1.movies[i].title + "\n" +
                    "year: " + data1.movies[i].year + "\n" +
                    "genre: " + data1.movies[i].genre + "\n" +
                    "rating: " + data1.movies[i].rating + "\n"

                    );
            }
            Console.WriteLine("\n");
        }
    }
}

