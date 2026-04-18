using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace MODUL7_KELOMPOK6
{
    internal class Info
    {
        public string id {  get; set; } = string.Empty;
        public string name {  get; set; } = string.Empty;
        public string description {  get; set; } = string.Empty;
        public List<string> popularMovies { get; set; } = new List<string>();

    }
    internal class GenreDict
    {
        public string category { get; set; } = string.Empty;
        public Info GenreInfo { get; set; } = new Info();


        public void ReadJson()
        {
            string path1 = @"..\..\..\lib\jurnal7_3_103022400032.json";
            string json1 = File.ReadAllText(path1);

            var data1 = JsonSerializer.Deserialize<GenreDict>(json1)
                        ?? new GenreDict();

            Console.WriteLine(
                "category: " + data1.category + "\n" +
                "GenreInfo: " + data1.GenreInfo + "\n"
                );
        }
    }






}
