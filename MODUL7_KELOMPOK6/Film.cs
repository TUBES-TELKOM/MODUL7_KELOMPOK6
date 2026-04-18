using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace MODUL7_KELOMPOK6
{
    internal class Film
    {
        public string title { get; set; } = string.Empty;
        public string director { get; set; } = string.Empty;
        public string year {  get; set; } = string.Empty;
        public string genre {  get; set; } = string.Empty;
        public double rating {  get; set; }
        public int durationMinutes {  get; set; }
        public bool isWatched {  get; set; }
    public void ReadJson()
        {
            string path1 = @"..\..\..\lib\jurnal7_1_103022400032.json";
            string json1 = File.ReadAllText(path1);

            var data1 = JsonSerializer.Deserialize<Film>(json1)
                        ?? new Film();

            Console.WriteLine(
                "title: " + data1.title + "\n" +
                "director: " + data1.director + "\n" +
                "year: " + data1.year+ "\n" +
                "genre: " + data1.genre + "\n" +
                "rating: " + data1.rating + "\n" +
                "durationMinutes: " + data1.durationMinutes + "\n" +
                "isWatched: " + data1.isWatched + "\n"
                );
        }
    }
}
