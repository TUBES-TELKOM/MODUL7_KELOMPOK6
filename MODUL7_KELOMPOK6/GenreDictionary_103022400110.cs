using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace MODUL7_KELOMPOK6
{
    internal class GenreInfo
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public List<string> popularMovies { get; set; } = new List<string>();
    }

    internal class GenreDictionary_103022400110
    {
        public string category { get; set; } = string.Empty;
        public GenreInfo genreInfo { get; set; } = new GenreInfo();

        public static void ReadJSON()
        {
            // JSON 1
            string path1 = @"..\..\..\lib\jurnal7_3_103022400110.json";
            // Membaca isi file JSON
            string json1 = File.ReadAllText(path1);
            var data1 = JsonSerializer.Deserialize<GenreDictionary_103022400110>(json1);
            
            Console.WriteLine("Category : " + data1.category);
            Console.WriteLine("ID : " + data1.genreInfo);

        }
    }
}
